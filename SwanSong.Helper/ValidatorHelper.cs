using FluentValidation;
using SwanSong.Domain.Dto.Response;
using SwanSong.Helper.Interfaces;
using SwanSong.Helper.Exceptions;
using System.Threading.Tasks;
using SwanSong.Domain.Dto;

namespace SwanSong.Helper;
public class ValidatorHelper<T> : IValidatorHelper<T>
{
    private readonly IValidator<T> _validator; 
    public ValidatorHelper(IValidator<T> validator)
    {
        _validator = validator; 
    } 

    public async Task ValidateAsync(T itemToValidate, string ruleSet)
    {
        var validationResult = await _validator.ValidateAsync(itemToValidate, options => options.IncludeRuleSets(ruleSet)); ;
        if (!validationResult.IsValid)
        {
            throw new FailedValidationException(new FailedValidationResponse(validationResult.Errors, false));
        }
    }

    public async Task<FluentValidation.Results.ValidationResult> AfterEventAsync(T itemToValidate, string ruleSet)
    {
        return await _validator.ValidateAsync(itemToValidate, options => options.IncludeRuleSets(ruleSet)); ;
    }
}