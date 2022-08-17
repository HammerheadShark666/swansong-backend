using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Helper;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class RecordLabelService : BaseService<RecordLabel, RecordLabelDto>, IRecordLabelService
    {
        public RecordLabelService(IMapper mapper,                                   
                                  IValidator<RecordLabel> validator, 
                                  IMemoryCache memoryCache, 
                                  IUnitOfWork unitOfWork,
                                  IAzureStorageHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        { }

        public async Task<List<RecordLabelReadOnlyDto>> GetAllAsync()
        {
            return await _memoryCache.GetOrCreateAsync<List<RecordLabelReadOnlyDto>>(CacheKeys.RecordLabel, async cache =>
            {
                cache.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30);
                return _mapper.Map<List<RecordLabelReadOnlyDto>>(await _unitOfWork.RecordLabels.AllAsync()).OrderBy(r => r.Name).ToList();
            });
        }
        
        public async Task<RecordLabelDto> GetAsync(int id)
        {           
            return _mapper.Map<RecordLabelDto>(await _unitOfWork.RecordLabels.ByIdAsync(id));
        }

        public async Task<RecordLabelDto> SaveAsync(RecordLabelDto recordLabelDto)
        {            
            RecordLabel recordLabel = await GetRecordLabelAsync(recordLabelDto); 

            ValidationResult result = await BeforeSaveAsync(recordLabel);
            if (!result.IsValid)            
                return GetDto(GetEntity(recordLabel), result.Errors, false);

            recordLabel = await SaveAsync(recordLabel);

            return GetDto(recordLabel, await AfterSaveAsync(recordLabel, CacheKeys.RecordLabel), true);
        }         

        public async Task<RecordLabelDto> DeleteAsync(int id)
        {
            RecordLabel recordLabel = await _unitOfWork.RecordLabels.ByIdAsync(id); 

            ValidationResult result = await BeforeDeleteAsync(recordLabel);
            if (!result.IsValid)           
                return GetDto(GetEntity(recordLabel), result.Errors, false);

            recordLabel = await DeleteAsync(recordLabel);

            return GetDto(recordLabel, await AfterDeleteAsync(recordLabel, CacheKeys.RecordLabel), true);
        } 

        private async Task<RecordLabel> GetRecordLabelAsync(RecordLabelDto recordLabelDto)
        {           
            RecordLabel currentRecordLabel = recordLabelDto.Id > 0 ? new() : await _unitOfWork.RecordLabels.ByIdAsync(recordLabelDto.Id);
            return _mapper.Map<RecordLabelDto, RecordLabel>(recordLabelDto, currentRecordLabel);
        }

        private async Task<RecordLabel> SaveAsync(RecordLabel recordLabel)
        {
            if (recordLabel.Id == 0)
                _unitOfWork.RecordLabels.Add(recordLabel);
            else
                _unitOfWork.RecordLabels.Update(recordLabel);

            await _unitOfWork.Complete();

            return recordLabel;
        }

        private async Task<RecordLabel> DeleteAsync(RecordLabel recordLabel)
        {
            _unitOfWork.RecordLabels.Remove(recordLabel);
            await _unitOfWork.Complete();

            return recordLabel;
        }
    }
}
