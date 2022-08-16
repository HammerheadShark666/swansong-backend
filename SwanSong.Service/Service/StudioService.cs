using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using SwanSong.Azure.Storage.Interfaces;

namespace SwanSong.Service
{
    public class StudioService : BaseService<Studio, StudioDto>, IStudioService
    {       
        public StudioService(IMapper mapper,
                             IValidator<Studio> validator,
                             IMemoryCache memoryCache,
                             IUnitOfWork unitOfWork,
                             IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<List<StudioReadOnlyDto>> GetAllAsync()
        {
            return await _memoryCache.GetOrCreateAsync<List<StudioReadOnlyDto>>(CacheKeys.Studio, async cache =>
            {
                cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
                return _mapper.Map<List<StudioReadOnlyDto>>(await _unitOfWork.Studios.AllAsync()).OrderBy(s => s.Name).ToList();
            });
        }

        public async Task<StudioDto> GetAsync(int id)
        {
            return _mapper.Map<StudioDto>(await _unitOfWork.Studios.ByIdAsync(id));
        }

        public async Task<StudioDto> SaveAsync(StudioDto studioDto)
        {
            Studio studio = await GetStudioAsync(studioDto); 

            ValidationResult result = BeforeSave(studio);
            if (!result.IsValid)
                return GetDto(GetEntity(studio), result.Errors, false);
             
            studio = await SaveAsync(studio); 

            return GetDto(studio, AfterSave(studio, CacheKeys.Studio), true);
        }                

        public async Task<StudioDto> DeleteAsync(int id)
        {
            Studio studio = await _unitOfWork.Studios.ByIdAsync(id);      

            ValidationResult result = BeforeDelete(studio);
            if (!result.IsValid)
                return GetDto(GetEntity(studio), result.Errors, false);             

            studio = await DeleteAsync(studio);

            return GetDto(studio, AfterDelete(studio, CacheKeys.Studio), true);
        }  

        private async Task<Studio> GetStudioAsync(StudioDto studioDto)
        {
            Studio currentStudio = studioDto.Id > 0 ? new() : await _unitOfWork.Studios.ByIdAsync(studioDto.Id);
            return _mapper.Map<StudioDto, Studio>(studioDto, currentStudio);
        }

        private async Task<Studio> SaveAsync(Studio studio)
        {
            if (studio.Id == 0)
                _unitOfWork.Studios.Add(studio);
            else
                _unitOfWork.Studios.Update(studio);

            await _unitOfWork.Complete();

            return studio;
        }

        private async Task<Studio> DeleteAsync(Studio studio)
        {
            _unitOfWork.Studios.Remove(studio);
            await _unitOfWork.Complete();

            return studio;
        }
    }
}
