using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;

namespace SwanSong.Business.Validator;

public class SongValidator : BaseValidator<Song>
{
    private readonly ISongRepository _songRepository;

    public SongValidator(ISongRepository songRepository)
    {
        _songRepository = songRepository;

        RuleSet("BeforeSave", () => {

            RuleFor(song => song.Title)
                .NotEmpty().WithMessage("Title is required.")
                .Length(1, 150).WithMessage("Title length between 1 and 150.");

            When(song => song.Length != null, () => {
                RuleFor(song => song.Length)
                    .Matches(@"(?:[012345]\d):(?:[012345]\d)")
                    .WithMessage("Length must be in format mm:ss, e.g. 45:23");
            }); 
        });

        RuleSet("AfterSave", () => {

            RuleFor(song => song)
                .NotNull().WithMessage("The songs ha been saved."); 
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => {

            RuleFor(song => song)
                .Null()
                .WithSeverity(Severity.Info)
                .WithMessage("The song has been deleted.");
        });
    }            
}
