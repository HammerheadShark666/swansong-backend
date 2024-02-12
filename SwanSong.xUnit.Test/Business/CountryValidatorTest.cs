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

public class CountryValidatorTest
{
    private Mock<ICountryRepository> countryRepositoryMock;
    private IValidator<Country> validator;

    private static readonly Country newCountry = new() { Id = 0, Name = "Test Country 1" };
    private static readonly Country existingCountry = new() { Id = 1, Name = "Test Country 1" };

     
    public CountryValidatorTest()
    {
        countryRepositoryMock = new Mock<ICountryRepository>();
        validator = new CountryValidator(countryRepositoryMock.Object);
    }

    [Fact]
    public async void Before_save_validate_country_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingCountry, options => options
                                                                            .IncludeRuleSets("BeforeSave"));
        Assert.True(validation.IsValid);
    }

    [Fact]
    public async void After_save_validate_country_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingCountry, options => options
                                                                            .IncludeRuleSets("AfterSave"));
        Assert.False(validation.IsValid);
        Assert.Equal("The country has been saved.", validation.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_country_name_null_return_false()
    {
        Country country = new() { Id = 1, Name = "" };
        ValidationResult validationResult = await validator.ValidateAsync(country, options => options
                                                                            .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name is required.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_country_name_empty_return_false()
    {
        Country country = new() { Id = 1, Name = "" };
        ValidationResult validationResult = await validator.ValidateAsync(country, options => options
                                                                            .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name length between 1 and 50.", validationResult.Errors[1].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_country_name_over_50_characters_return_false()
    {
        Country country = new() { Id = 1, Name = UnitTestHelper.generateRandomString(51) };
        ValidationResult validationResult = await validator.ValidateAsync(country, options => options
                                                                            .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Name length between 1 and 50.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_insert_save_validate_country_insert_name_duplicate_return_false()
    {
        Country country = new() { Id = 0, Name = "Test Country" };

        countryRepositoryMock.Setup(p => p.ExistsAsync("Test Country")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(country, options => options
                                                                            .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Country already exists.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_update_save_validate_country_update_name_duplicate_return_false()
    {
        Country country = new() { Id = 1, Name = "Test Country" };

        countryRepositoryMock.Setup(p => p.ExistsAsync(1, "Test Country")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(country, options => options
                                                                            .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Country already exists.", validationResult.Errors[0].ErrorMessage);
    } 
}
