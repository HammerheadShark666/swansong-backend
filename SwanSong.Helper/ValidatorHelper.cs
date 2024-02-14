using FluentValidation;
using SwanSong.Domain.Dto;
using SwanSong.Helper.Exceptions;
using SwanSong.Helper.Interfaces;
using System.Threading.Tasks;

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