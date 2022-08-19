using FluentValidation;
using FluentValidation.Results;
using Moq;
using SwanSong.Business.Validator;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.xUnit.Test.Helpers;
using System;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SwanSong.xUnit.Test.Business
{
    public class AlbumValidatorTest
    {
        private Mock<IAlbumRepository> albumRepositoryMock;
        private IValidator<Album> validator;

        public AlbumValidatorTest()
        {
            albumRepositoryMock = new Mock<IAlbumRepository>();
            validator = new AlbumValidator(albumRepositoryMock.Object);
        }

        [Fact]
        public async void Before_save_validate_album_return_true()
        {
            ValidationResult validation = await validator.ValidateAsync(CreateAlbum(), options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.True(validation.IsValid);
        }

        [Fact]
        public async void After_save_validate_album_return_true()
        {
            ValidationResult validation = await validator.ValidateAsync(CreateAlbum(), options => options
                                                                                .IncludeRuleSets("AfterSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("The album Test Album has been saved.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_no_artist_id_return_false()
        {
            Album album = CreateAlbum();
            album.ArtistId = 0;
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Artist is required.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_album_name_null_return_false()
        {
            Album album = CreateAlbum(1, null);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Album name is required.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_album_name_empty_return_false()
        {
            Album album = CreateAlbum(1, "");
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Album name is required.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_album_name_greater_than_120_return_false()
        {
            Album album = CreateAlbum(1, "AbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijAbcdefghijX");
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Album name length between 1 and 120.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_existing_album_album_name_exists_return_false()
        {
            albumRepositoryMock.Setup(p => p.ExistsAsync(1, "Test Album")).Returns(Task.FromResult(true));

            Album album = CreateAlbum(1, "Test Album");
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Test Album already exists.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_new_album_album_name_exists_return_false()
        {
            albumRepositoryMock.Setup(p => p.ExistsAsync("Test Album")).Returns(Task.FromResult(true));

            Album album = CreateAlbum(0);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Test Album already exists.", validation.Errors[0].ErrorMessage);
        }         

        [Fact]
        public async void Before_save_validate_album_release_date_less_than_1900_01_01_return_false()
        {
            Album album = CreateAlbum();
            album.ReleaseDate = new DateTime(1899, 12, 31);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Release date must be after 1/1/1900.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_recorded_date_less_than_1900_01_01_return_false()
        {
            Album album = CreateAlbum();
            album.RecordedDate = new DateTime(1899, 12, 31);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Recorded date must be after 1/1/1900.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_release_date_less_than_recorded_date_return_false()
        {
            Album album = CreateAlbum();
            album.RecordedDate = new DateTime(1990, 1, 1);
            album.ReleaseDate = new DateTime(1989, 12, 31);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Release date must be after recorded date.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_album_producers_greater_than_250_return_false()
        {
            Album album = CreateAlbum();
            album.Producers = UnitTestHelper.generateRandomString(251);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Producers maximum length is 250.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_album_arrangers_greater_than_250_return_false()
        {
            Album album = CreateAlbum();
            album.Arrangers = UnitTestHelper.generateRandomString(251);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Arrangers maximum length is 250.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_album_engineers_greater_than_250_return_false()
        {
            Album album = CreateAlbum();
            album.Engineers = UnitTestHelper.generateRandomString(251);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Engineers maximum length is 250.", validation.Errors[0].ErrorMessage);
        }

        [Fact]
        public async void Before_save_validate_album_album_artwork_greater_than_250_return_false()
        {
            Album album = CreateAlbum();
            album.Artwork = UnitTestHelper.generateRandomString(101);
            ValidationResult validation = await validator.ValidateAsync(album, options => options
                                                                                .IncludeRuleSets("BeforeSave"));
            Assert.False(validation.IsValid);
            Assert.Equal("Artwork maximum length is 100.", validation.Errors[0].ErrorMessage);
        }

        private Album CreateAlbum(int id = 1, string name = "Test Album", int artistId = 1)
        {
            return new Album()
            {
                Id = id,
                Name = name,
                ArtistId = artistId,
                Photo = "",
                RecordedDate = new DateTime(1990, 12, 1),
                ReleaseDate = new DateTime(1991, 6, 1),
                LabelId = 1,
                StudioId = 1, 
                Producers = "Test Producers",
                Arrangers = "Test Arrangers",
                Engineers = "Test Engineers",
                Artwork = "Test Artwork"
            };
        }
    }
}
