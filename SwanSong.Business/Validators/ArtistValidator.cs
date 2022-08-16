using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator
{
    public class ArtistValidator : BaseValidator<Artist>
    {
        private readonly IArtistRepository _artistRepository;

        public ArtistValidator(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;

            RuleSet("BeforeSave", () =>
            {               
                RuleFor(artist => artist.Name)
                    .NotEmpty().WithMessage("Artist name is required.")
                    .Length(1, 100).WithMessage("Artist name length between 1 and 100.");                    

                RuleFor(artist => artist).MustAsync(async (artist, cancellation) => {
                    return await ArtistNameExists(artist);
                }).WithMessage(artist => $"{artist.Name} already exists.");

                RuleFor(artist => artist.FormationYear)
                    .GreaterThan(1900);

                RuleFor(artist => artist.DisbandYear)
                    .GreaterThan(artist => artist.FormationYear)
                    .When(artist => artist.FormationYear != null)
                    .When(artist => artist.DisbandYear != null)
                    .WithMessage("Disband year must be after formation year.");

                RuleFor(artist => artist.DisbandYear)
                    .GreaterThan(1900);
            });

            RuleSet("AfterSave", () => {

                RuleFor(artist => artist)
                   .Null()
                   .WithSeverity(Severity.Info)
                   .WithMessage("The artist has been saved.");
            });

            RuleSet("BeforeDelete", () => {

                 
            });

            RuleSet("AfterDelete", () => {

                RuleFor(artist => artist)
                    .Null()
                    .WithSeverity(Severity.Info)
                    .WithMessage("The artist has been deleted.");
            });
        }

        protected async Task<bool> ArtistNameExists(Artist artist)
        {
            return artist.Id == 0
                ? !(await _artistRepository.ExistsAsync(artist.Name))
                : !(await _artistRepository.ExistsAsync(artist.Id, artist.Name));
        } 
    }
}
