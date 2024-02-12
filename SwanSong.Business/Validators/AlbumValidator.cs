using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator;

public class AlbumValidator : BaseValidator<Album>
{
    private readonly IAlbumRepository _albumRepository;

    public AlbumValidator(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;

        RuleSet("BeforeSave", () => {
                            
            RuleFor(album => album.Name) 
                .NotEmpty().WithMessage("Album name is required.")
                .Length(1, 120).WithMessage("Album name length between 1 and 120.");                 

            RuleFor(album => album).MustAsync(async (album, cancellation) => {
                return await AlbumNameExists(album); 
            }).WithMessage(album => $"{album.Name} already exists.");

            RuleFor(album => album.ArtistId) 
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Artist is required."); 

            RuleFor(album => album.ReleaseDate)
                .GreaterThan(new DateTime(1900, 1, 1))
                .WithMessage("Release date must be after 1/1/1900.");

            RuleFor(album => album.ReleaseDate)
                .GreaterThan(album => album.RecordedDate)
                .When(album => album.ReleaseDate != null)
                .When(album => album.RecordedDate != null)
                .WithMessage("Release date must be after recorded date.");

            RuleFor(album => album.RecordedDate)
                .GreaterThan(new DateTime(1900, 1, 1))
                .WithMessage("Recorded date must be after 1/1/1900.");                

            RuleFor(album => album.Producers) 
                .Length(0, 250)
                .WithMessage("Producers maximum length is 250.");

            RuleFor(album => album.Arrangers)
                .Length(0, 250)
                .WithMessage("Arrangers maximum length is 250.");

            RuleFor(album => album.Engineers)
                .Length(0, 250)
                .WithMessage("Engineers maximum length is 250.");

            RuleFor(album => album.Artwork)
                .Length(0, 100)
                .WithMessage("Artwork maximum length is 100.");
        });

        RuleSet("AfterSave", () => {

            RuleFor(album => album)
               .Null()
               .WithSeverity(Severity.Info)
               .WithMessage(a => $"The album {a.Name} has been saved.");
        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => {

            RuleFor(album => album)
                .Null()
                .WithSeverity(Severity.Info)
                .WithMessage(a => $"The album {a.Name} has been deleted."); 
        });
    }

    protected async Task<bool> AlbumNameExists(Album album)
    {
        return album.Id == 0
            ? !(await _albumRepository.ExistsAsync(album.Name))
            : !(await _albumRepository.ExistsAsync(album.Id, album.Name));
    }
}
