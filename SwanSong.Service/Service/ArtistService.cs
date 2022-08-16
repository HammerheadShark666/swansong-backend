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
    public class ArtistService : BaseService<Artist, ArtistDto>, IArtistService
    { 
        public ArtistService(IMapper mapper,
                             IValidator<Artist> validator,
                             IMemoryCache memoryCache,
                             IUnitOfWork unitOfWork,
                             IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        {}

        public async Task<long> CountAsync()
        {
            return await _unitOfWork.Artists.CountAsync();
        }

        public async Task<List<ArtistReadOnlyDto>> GetAllAsync(PaginationFilter filter)
        {
            return _mapper.Map<List<ArtistReadOnlyDto>>(await _unitOfWork.Artists.GetAllAsync(filter.PageNumber, filter.PageSize)).OrderBy(a => a.Name).ToList();
        }

        public async Task<List<ArtistReadOnlyDto>> GetRandomAsync(int numberOfArtists)
        {
            return _mapper.Map<List<ArtistReadOnlyDto>>(await _unitOfWork.Artists.GetRandomAsync(numberOfArtists)).OrderBy(a => a.Name).ToList();
        }

        public async Task<List<ArtistReadOnlyDto>> SearchByNameAsync(string criteria)
        {
            return _mapper.Map<List<ArtistReadOnlyDto>>(await _unitOfWork.Artists.SearchByNameAsync(criteria)); 
        }

        public async Task<List<ArtistReadOnlyDto>> SearchByAlphaNumericAsync(string alphanumeric) 
        {
            return _mapper.Map<List<ArtistReadOnlyDto>>(await _unitOfWork.Artists.SearchByAlphaNumericAsync(alphanumeric)); 
        }

        public async Task<ArtistDto> GetAsync(long id)
        { 
            return _mapper.Map<ArtistDto>(await _unitOfWork.Artists.GetAsync(id));
        }

        public async Task<string> UpdateArtistPhotoAsync(long id, IFormFile file)
        {
            Artist artist = await _unitOfWork.Artists.GetAsync(id);
            if (artist == null)
                throw new Exception(ConstantMessages.ArtistNotFound);

            string newFileName = FileHelper.getGuidFileName(Constants.FileExtensionJpg);
            string originalFileName = artist.Photo;

            ArtistDto artistDto = _mapper.Map<ArtistDto>(await _unitOfWork.Artists.UpdateArtistPhotoAsync(id, newFileName));
            
            await _azureStorageHelper.SaveFileToAzureStorageContainerAsync(file, Constants.AzureStorageContainerArtists, newFileName);
            await DeleteOriginalFileAsync(originalFileName, newFileName, Constants.AzureStorageContainerArtists);

            return newFileName;
        }

        public async Task<ArtistDto> SaveAsync(ArtistDto artistDto)
        { 
            Artist artist = await GetArtistAsync(artistDto); 

            ValidationResult result = BeforeSave(artist);
            if (!result.IsValid)
                return GetDto(artist, result.Errors, false);

            artist = await SaveAsync(artist);

            return GetDto(artist, AfterSave(artist, null), true);
        }

        public async Task<ArtistDto> DeleteAsync(long id)
        {
            Artist artist = await _unitOfWork.Artists.GetWithMembersAsync(id);

            ValidationResult result = BeforeDelete(artist);
            if (!result.IsValid)
                return GetDto(artist, result.Errors, false);

            artist = await DeleteAsync(artist);
            
            if(notDefaultImage(artist.Photo))
                await _azureStorageHelper.DeleteFileInAzureStorageContainerAsync(artist.Photo, Constants.AzureStorageContainerArtists);
            
            await DeleteMembersAsync(artist.Members);
            
            return GetDto(artist, AfterDelete(artist, null), true);
        }


        public async Task<List<ArtistLookupDto>> GetLookupsAsync()
        {
            return _mapper.Map<List<ArtistLookupDto>>(await _unitOfWork.Artists.AllAsync()).OrderBy(a => a.Name).ToList();
        }

        private async Task<Artist> GetArtistAsync(ArtistDto artistDto)
        {
            Artist currentArtist = artistDto.Id == 0 ? new() : await _unitOfWork.Artists.GetAsync(artistDto.Id);
            return _mapper.Map<ArtistDto, Artist>(artistDto, currentArtist);
        }  

        private async Task<Artist> SaveAsync(Artist artist)
        {
            if (artist.Id == 0)
                _unitOfWork.Artists.Add(artist);
            else
                _unitOfWork.Artists.Update(artist);

            await _unitOfWork.Complete();

            return artist;
        }

        private async Task<Artist> DeleteAsync(Artist artist)
        {
            _unitOfWork.Artists.Remove(artist);
            await _unitOfWork.Complete();

            return artist;
        }

        private async Task DeleteMembersAsync(List<Member> members)
        {
            foreach (Member member in members)
                await _azureStorageHelper.DeleteFileInAzureStorageContainerAsync(member.Photo, Constants.AzureStorageContainerMembers);

            return;
        }

    }
}
