using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Model.Settings;
using SwanSong.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SwanSong.Service
{
    public class BaseService<T, D> where T : class, new()
                                   where D : BaseDto
    {
        private readonly IValidator<T> _validator;
        public readonly IMemoryCache _memoryCache;
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public readonly IAzureStorageHelper _azureStorageHelper;

        public record EditPhoto(bool photoWasChanged, string originalPhotoName);

        public BaseService(IValidator<T> validator, IMemoryCache memoryCache, IUnitOfWork unitOfWork, IMapper mapper, IAzureStorageHelper azureStorageHelper)
        {
            _validator = validator;
            _memoryCache = memoryCache;
            _unitOfWork = unitOfWork;
            _mapper = mapper; 
            _azureStorageHelper = azureStorageHelper; 
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public async Task<ValidationResult> BeforeSaveAsync(T item)
        {
            return await _validator.ValidateAsync(item, options => options
                                        .IncludeRuleSets("BeforeSave"));
        }

        public async Task<List<FluentValidation.Results.ValidationFailure>> AfterSaveAsync(T item, string cacheKey)
        {
            if (cacheKey != null)
                _memoryCache.Remove(cacheKey);

            var afterSaveRules = await _validator.ValidateAsync(item, options => options
                                        .IncludeRuleSets("AfterSave")); 

            return afterSaveRules.Errors.Count > 0 ? afterSaveRules.Errors : new();
        }

        public async Task<ValidationResult> BeforeDeleteAsync(T item)
        {
            return await _validator.ValidateAsync(item, options => options
                                        .IncludeRuleSets("BeforeDelete"));
        }

        public async Task<List<ValidationFailure>> AfterDeleteAsync(T item, string cacheKey)
        {
            if (cacheKey != null)
                _memoryCache.Remove(cacheKey);

            var afterDeleteRules = await _validator.ValidateAsync(item, options => options
                                        .IncludeRuleSets("AfterDelete"));

            return (afterDeleteRules != null && afterDeleteRules.Errors.Count > 0) ? afterDeleteRules.Errors : new();
        }

        public void Send(SendGridSettings sendGridSettings, string email, string subject, string html)
        {
            EmailHelper.SendEmail(sendGridSettings, email, subject, $@"{html}");
        }

        public D GetDto(T entity, List<ValidationFailure> rules, bool isValid)
        {
            D dto = _mapper.Map<D>(entity);
            dto.Rules = rules;
            dto.IsValid = isValid;
            return dto;
        }

        public T GetEntity(T entity)
        {
            return entity ?? new T();
        }

        public EditPhoto wasPhotoEdited(string originalPhotoFileName, string newPhotoFileName)
        {
            return new EditPhoto(((originalPhotoFileName != null && newPhotoFileName != null && notDefaultImage(originalPhotoFileName))
                                        && (originalPhotoFileName != newPhotoFileName)), originalPhotoFileName);
        }

        public async Task DeleteOriginalFileAsync(string originalFileName, string newFileName, string container)
        {
            EditPhoto editPhoto = wasPhotoEdited(originalFileName, newFileName);
            if (editPhoto.photoWasChanged)
                await _azureStorageHelper.DeleteFileInAzureStorageContainerAsync(editPhoto.originalPhotoName, container);
        }

        public bool notDefaultImage(string fileName)
        {
            return !(fileName == Constants.DefaultAlbumPhotoFileName
                    || fileName == Constants.DefaultArtistPhotoFileName
                    || fileName == Constants.DefaultMemberPhotoFileName);            
        }
    }
}
