using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Filter;
using SwanSong.Helper.Interfaces;
using SwanSong.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class MemberService : IMemberService
{
    public readonly IMemoryCache _memoryCache;
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Member> _validatorHelper;
    public readonly IAzureStorageBlobHelper _azureStorageHelper;

    public record EditPhoto(bool photoWasChanged, string originalPhotoName);

    public MemberService(IMapper mapper,
                         IValidatorHelper<Member> validatorHelper,
                         IMemoryCache memoryCache,
                         IUnitOfWork unitOfWork,
                         IAzureStorageBlobHelper azureStorageHelper)
    {
        _azureStorageHelper = azureStorageHelper;
        _validatorHelper = validatorHelper;
        _memoryCache = memoryCache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<long> CountAsync()
    {
        return await _unitOfWork.Members.CountAsync();
    }

    public async Task<List<MemberResponse>> GetAllAsync(PaginationFilter filter)
    {
        return _mapper.Map<List<MemberResponse>>(await _unitOfWork.Members.GetAllAsync(filter.PageNumber, filter.PageSize));
    }

    public async Task<List<MemberResponse>> GetRandomAsync(int numberOfMember)
    {
        return _mapper.Map<List<MemberResponse>>(await _unitOfWork.Members.GetRandomAsync(numberOfMember)).OrderBy(a => a.StageName).ToList();
    }

    public async Task<List<MemberResponse>> SearchByNameAsync(string criteria)
    {
        return _mapper.Map<List<MemberResponse>>(await _unitOfWork.Members.SearchByNameAsync(criteria));
    }

    public async Task<List<MemberResponse>> SearchByLetterAsync(string letter)
    {
        return _mapper.Map<List<MemberResponse>>(await _unitOfWork.Members.SearchByLetterAsync(letter));
    }

    public async Task<List<MemberResponse>> GetMembersByArtistAsync(long artistId)
    {
        return _mapper.Map<List<MemberResponse>>(await _unitOfWork.Members.GetMembersByArtistAsync(artistId));
    }

    public async Task<MemberResponse> GetAsync(long id)
    {
        return _mapper.Map<MemberResponse>(await _unitOfWork.Members.GetAsync(id));
    }

    public async Task<MemberActionResponse> AddAsync(MemberAddRequest memberAddRequest)
    {
        Member member = _mapper.Map<Member>(memberAddRequest);

        await BeforeSaveAsync(member);
        await SaveAddAsync(member);

        return await AfterSaveAsync(member); 
    }

    public async Task<MemberActionResponse> UpdateAsync(MemberUpdateRequest memberUpdateRequest)
    {
        var member = await UpdateMemberAsync(memberUpdateRequest);

        await BeforeSaveAsync(member);
        await SaveUpdateAsync(member);

        return await AfterSaveAsync(member); 
    }

    public async Task<MemberActionResponse> DeleteAsync(long id)
    {
        var member = await GetMemberAsync(id);

        await BeforeDeleteAsync(member);
        await DeleteAsync(member);

        if (NoDefaultImage(member.Photo))
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(member.Photo, Constants.AzureStorageContainerMembers);
        }

        return await AfterDeleteAsync(member); 
    }

    public async Task<MemberPhotoActionResponse> UpdateMemberPhotoAsync(long id, IFormFile file)
    {
        Member member = await GetMemberAsync(id);

        string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
        string originalFileName = member.Photo;

        await _azureStorageHelper.SaveBlobToAzureStorageContainerAsync(file, Constants.AzureStorageContainerMembers, newFileName);
        await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerMembers);
        await _unitOfWork.Members.UpdateMemberPhotoAsync(id, newFileName);

        return new MemberPhotoActionResponse(newFileName, true); 
    }

    #endregion

    #region Private Functions

    private async Task<Member> UpdateMemberAsync(MemberUpdateRequest memberUpdateRequest)
    {
        Member member = await GetMemberAsync(memberUpdateRequest.Id);
        return _mapper.Map<MemberUpdateRequest, Member>(memberUpdateRequest, member); 
    }

    private async Task BeforeSaveAsync(Member member)
    {
        await _validatorHelper.ValidateAsync(member, Constants.ValidationEventBeforeSave);
    }

    private async Task<MemberActionResponse> AfterSaveAsync(Member member)
    {
        var afterSaveValidate = await _validatorHelper.AfterEventAsync(member, Constants.ValidationEventAfterSave);
        return new MemberActionResponse(member.Id, ResponseHelper.GetMessages(afterSaveValidate.Errors), true);
    }

    private async Task BeforeDeleteAsync(Member member)
    {
        await _validatorHelper.ValidateAsync(member, Constants.ValidationEventBeforeDelete);
    }

    private async Task<MemberActionResponse> AfterDeleteAsync(Member member)
    {
        var afterDeleteValidate = await _validatorHelper.AfterEventAsync(member, Constants.ValidationEventAfterDelete);
        return new MemberActionResponse(member.Id, ResponseHelper.GetMessages(afterDeleteValidate.Errors), true);
    }

    private async Task DeleteAsync(Member member)
    {
        _unitOfWork.Members.Delete(member);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }

    private async Task SaveAddAsync(Member member)
    {
        await _unitOfWork.Members.AddAsync(member);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    }

    private async Task SaveUpdateAsync(Member member)
    {
        _unitOfWork.Members.Update(member);
        await DataHelper.CompleteContextActionAsync(null, _memoryCache, _unitOfWork);
    } 
  
    private async Task<Member> GetMemberAsync(long id)
    {
        var member = await _unitOfWork.Members.ByIdAsync(id);
        if (member == null)
        {
            throw new MemberNotFoundException("Member not found.");
        }

        return member;
    }
 
    private bool NoDefaultImage(string fileName)
    {
        return !(fileName == Constants.DefaultMemberPhotoFileName);
    }

    private async Task DeleteOriginalFileAsync(string originalFileName, string newFileName, string container)
    {
        EditPhoto editPhoto = WasPhotoEdited(originalFileName, newFileName);
        if (editPhoto.photoWasChanged)
        {
            await _azureStorageHelper.DeleteBlobInAzureStorageContainerAsync(editPhoto.originalPhotoName, container);
        }
    }

    private EditPhoto WasPhotoEdited(string originalPhotoFileName, string newPhotoFileName)
    {
        return new EditPhoto(((originalPhotoFileName != null && newPhotoFileName != null && NoDefaultImage(originalPhotoFileName))
                                    && (originalPhotoFileName != newPhotoFileName)), originalPhotoFileName);
    } 

    #endregion
}