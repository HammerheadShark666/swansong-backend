using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator
{
    public class AlbumSongValidator : BaseValidator<AlbumSong>
    {
        private readonly IAlbumSongRepository _albumSongRepository;

        public AlbumSongValidator(IAlbumSongRepository albumSongRepository, ISongRepository songRepository)
        {
            _albumSongRepository = albumSongRepository;

            RuleSet("BeforeSave", () => {

                RuleFor(albumSong => albumSong.Song.Title)
                    .NotEmpty().WithMessage("Song title is required.")
                    .Length(1, 120).WithMessage("Song title length between 1 and 150.");

                RuleFor(albumSong => albumSong).MustAsync(async (albumSong, cancellation) => {
                    return await AlbumSongNameExists(albumSong);
                }).WithMessage(albumSong => $"{albumSong.Song.Title} already exists.");

                RuleFor(albumSong => albumSong)
                    .Must(SongLengthValid)
                    .WithMessage(albumSong => $"Length is invalid. Input as mm:ss");
            });

            RuleSet("AfterSave", () => {

                RuleFor(albumSong => albumSong)
                   .Null()
                   .WithSeverity(Severity.Info)
                   .WithMessage("The album song has been saved.");
            });

            RuleSet("BeforeDelete", () => {
               
            });

            RuleSet("AfterDelete", () => {

                RuleFor(albumSong => albumSong)
                    .Null()
                    .WithSeverity(Severity.Info)
                    .WithMessage("The album song has been deleted.");
            });
        }

        protected async Task<bool> AlbumSongNameExists(AlbumSong albumSong)
        {      
            return albumSong.Id == 0
                ? !(await _albumSongRepository.ExistsAsync(albumSong.AlbumId, albumSong.Song.Title))
                : !(await _albumSongRepository.ExistsAsync(albumSong.Id, albumSong.AlbumId, albumSong.Song.Title));             
        }

        protected static bool SongLengthValid(AlbumSong albumSong)
        {
            if (albumSong.Song.Length == null || albumSong.Song.Length == "")
                return true;
              
            Regex rg = new(@"^[0-5]?\d:[0-5]\d$");
            return rg.IsMatch(albumSong.Song.Length);
        }
    }
}
