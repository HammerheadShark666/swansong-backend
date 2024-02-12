using FluentValidation;
using FluentValidation.Results;

namespace SwanSong.Business.Validator;

public class BaseValidator<T> : AbstractValidator<T>
{
    public override ValidationResult Validate(ValidationContext<T> context)
    {
        return context.InstanceToValidate == null
            ? new ValidationResult(new[] { new ValidationFailure(nameof(T), "Not Found") })
            : base.Validate(context);
    }
} 
