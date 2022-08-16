using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Helper.Filter;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class MemberService : BaseService<Member, MemberDto>, IMemberService
    {
        public MemberService(IMapper mapper,
                             IValidator<Member> validator,
                             IMemoryCache memoryCache,
                             IUnitOfWork unitOfWork,
                             IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<long> CountAsync()
        {
            return await _unitOfWork.Members.CountAsync();
        }

        public async Task<List<MemberReadOnlyDto>> GetAllAsync(PaginationFilter filter)
        {
            return _mapper.Map<List<MemberReadOnlyDto>>(await _unitOfWork.Members.GetAllAsync(filter.PageNumber, filter.PageSize));
        }

        public async Task<List<MemberReadOnlyDto>> GetRandomAsync(int numberOfMember)
        {
            return _mapper.Map<List<MemberReadOnlyDto>>(await _unitOfWork.Members.GetRandomAsync(numberOfMember)).OrderBy(a => a.StageName).ToList();
        }

        public async Task<List<MemberReadOnlyDto>> SearchByNameAsync(string criteria)
        {
            return _mapper.Map<List<MemberReadOnlyDto>>(await _unitOfWork.Members.SearchByNameAsync(criteria));
        }

        public async Task<List<MemberReadOnlyDto>> SearchByLetterAsync(string letter)
        {
            return _mapper.Map<List<MemberReadOnlyDto>>(await _unitOfWork.Members.SearchByLetterAsync(letter));
        }

        public async Task<List<MemberDto>> GetMembersByArtistAsync(long artistId)
        {
            return _mapper.Map<List<MemberDto>>(await _unitOfWork.Members.GetMembersByArtistAsync(artistId));
        }

        public async Task<MemberDto> GetAsync(long id)
        {
            return _mapper.Map<MemberDto>(await _unitOfWork.Members.GetAsync(id));
        }

        public async Task<MemberDto> SaveAsync(MemberDto memberDto)
        {
            Member member = await GetMemberAsync(memberDto); 

            ValidationResult result = await BeforeSaveAsync(member);
            if (!result.IsValid)
                return GetDto(GetEntity(member), result.Errors, false); 

            member = await SaveAsync(member); 

            return GetDto(member, await AfterSaveAsync(member, null), true);
        }

        public async Task<MemberDto> DeleteAsync(long id)
        {
            Member member = await _unitOfWork.Members.GetAsync(id);

            ValidationResult result = await BeforeDeleteAsync(member);
            if (!result.IsValid)
                return GetDto(GetEntity(member), result.Errors, false);

            member = await DeleteAsync(member);

            if (notDefaultImage(member.Photo))
                await _azureStorageHelper.DeleteFileInAzureStorageContainerAsync(member.Photo, Constants.AzureStorageContainerMembers);

            return GetDto(member, await AfterDeleteAsync(member, null), true);
        }

        public async Task<string> UpdateMemberPhotoAsync(long id, IFormFile file)
        {
            Member member = await _unitOfWork.Members.GetAsync(id);
            if (member == null)
                throw new Exception(ConstantMessages.MemberNotFound);

            string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
            string originalFileName = member.Photo;

            MemberDto memberDto = _mapper.Map<MemberDto>(await _unitOfWork.Members.UpdateMemberPhotoAsync(id, newFileName));
            
            await _azureStorageHelper.SaveFileToAzureStorageContainerAsync(file, Constants.AzureStorageContainerMembers, newFileName);
            await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerMembers);
              
            return newFileName;
        }
                
        private async Task<Member> GetMemberAsync(MemberDto memberDto)
        {
            Member currentMember = memberDto.Id == 0 ? new() : await _unitOfWork.Members.GetAsync(memberDto.Id);
            return _mapper.Map<MemberDto, Member>(memberDto, currentMember);
        }         

        private async Task<Member> SaveAsync(Member member)
        {
            if (member.Id == 0)
                _unitOfWork.Members.Add(member);
            else
                _unitOfWork.Members.Update(member);

            await _unitOfWork.Complete();

            return member;
        }

        private async Task<Member> DeleteAsync(Member member)
        {
            _unitOfWork.Members.Remove(member);
            await _unitOfWork.Complete();

            return member;
        } 
    }
}
