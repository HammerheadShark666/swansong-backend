using FluentValidation;
using FluentValidation.Results;
using Moq;
using SwanSong.Business.Validator;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using SwanSong.xUnit.Test.Helpers;
using System.Threading.Tasks;
using Xunit;

namespace SwanSong.xUnit.Test.Business;

public class BirthPlaceValidatorTest
{
    private Mock<IBirthPlaceRepository> birthPlaceRepositoryMock;
    private IValidator<BirthPlace> validator;

    private static readonly BirthPlace newBirthPlace = new() { Id = 0, Name = "Test BirthPlace 1", CountryId = 1 };
    private static readonly BirthPlace existingBirthPlace = new() { Id = 1, Name = "Test BirthPlace 1", CountryId = 1 };
             
    public BirthPlaceValidatorTest()
    {
        birthPlaceRepositoryMock = new Mock<IBirthPlaceRepository>();
        validator = new BirthPlaceValidator(birthPlaceRepositoryMock.Object);
    }

    [Fact]
    public async void Before_save_validate_birth_place_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingBirthPlace, options => options
                                                                                    .IncludeRuleSets("BeforeSave"));
        Assert.True(validation.IsValid);
    }

    [Fact]
    public async void After_save_validate_birth_place_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingBirthPlace, options => options
                                                                            .IncludeRuleSets("AfterSave"));
        Assert.False(validation.IsValid);
        Assert.Equal("The birth place has been saved.", validation.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_birth_place_name_null_return_false()
    {
        BirthPlace birthPlace = new() { Id = 1, Name = "", CountryId = 1 };
        ValidationResult validationResult = await validator.ValidateAsync(birthPlace, options => options
                                                     .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name is required.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_birth_place_name_empty_return_false()
    {
        BirthPlace birthPlace = new() { Id = 1, Name = "", CountryId = 1 };
        ValidationResult validationResult = await validator.ValidateAsync(birthPlace, options => options
                                                     .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name length between 1 and 100.", validationResult.Errors[1].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_birth_place_name_over_100_characters_return_false()
    {
        BirthPlace birthPlace = new() { Id = 1, Name = UnitTestHelper.generateRandomString(101), CountryId = 1 };
        ValidationResult validationResult = await validator.ValidateAsync(birthPlace, options => options
                                                     .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Name length between 1 and 100.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_insert_save_validate_birth_place_insert_name_duplicate_return_false()
    {
        BirthPlace birthPlace = new() { Id = 0, Name = "Test Birth Place", CountryId = 1 };

        birthPlaceRepositoryMock.Setup(p => p.ExistsAsync("Test Birth Place")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(birthPlace, options => options
                                                     .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Birth Place already exists.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_update_save_validate_birth_place_update_name_duplicate_return_false()
    {
        BirthPlace birthPlace = new() { Id = 1, Name = "Test Birth Place", CountryId = 1 };

        birthPlaceRepositoryMock.Setup(p => p.ExistsAsync(1, "Test Birth Place")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(birthPlace, options => options
                                                     .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Birth Place already exists.", validationResult.Errors[0].ErrorMessage);
    }         
}
