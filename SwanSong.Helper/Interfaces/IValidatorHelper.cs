using System.Threading.Tasks;

namespace SwanSong.Helper.Interfaces;

public interface IValidatorHelper<T>
{
    Task ValidateAsync(T itemToValidate, string ruleSet);
    Task<FluentValidation.Results.ValidationResult> AfterEventAsync(T itemToValidate, string ruleSet); 
}