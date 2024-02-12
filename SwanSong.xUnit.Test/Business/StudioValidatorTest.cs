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

public class StudioValidatorTest
{
    private Mock<IStudioRepository> studioRepositoryMock;
    private IValidator<Studio> validator;

    private static readonly Studio newStudio = new() { Id = 0, Name = "Test Studio 1" };
    private static readonly Studio existingStudio = new() { Id = 1, Name = "Test Studio 1" };

     
    public StudioValidatorTest()
    {
        studioRepositoryMock = new Mock<IStudioRepository>();
        validator = new StudioValidator(studioRepositoryMock.Object);
    }

    [Fact]
    public async void Before_save_validate_studio_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingStudio);
        Assert.True(validation.IsValid);
    }

    [Fact]
    public async void After_save_validate_studio_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingStudio, options => options
                                                                            .IncludeRuleSets("AfterSave"));
        Assert.False(validation.IsValid);
        Assert.Equal("The studio has been saved.", validation.Errors[0].ErrorMessage);
    }               

    [Fact]
    public async void Before_save_validate_studio_name_null_return_false()
    {
        Studio Studio = new() { Id = 1, Name = "" };
        ValidationResult validationResult = await validator.ValidateAsync(Studio, options => options
                                                                            .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name is required.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_studio_name_empty_return_false()
    {
        Studio Studio = new() { Id = 1, Name = "" };
        ValidationResult validationResult = await validator.ValidateAsync(Studio, options => options
                                                                            .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name length between 1 and 250.", validationResult.Errors[1].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_studio_name_over_100_characters_return_false()
    {
        Studio Studio = new() { Id = 1, Name = UnitTestHelper.generateRandomString(251) };
        ValidationResult validationResult = await validator.ValidateAsync(Studio, options => options
                                                                        .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Name length between 1 and 250.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_insert_save_validate_studio_insert_name_duplicate_return_false()
    {
        Studio Studio = new() { Id = 0, Name = "Test Studio" };

        studioRepositoryMock.Setup(p => p.ExistsAsync("Test Studio")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(Studio, options => options
                                                                         .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Studio already exists.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_update_save_validate_studio_update_name_duplicate_return_false()
    {
        Studio Studio = new() { Id = 1, Name = "Test Studio" };

        studioRepositoryMock.Setup(p => p.ExistsAsync(1, "Test Studio")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(Studio, options => options
                                                                         .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Studio already exists.", validationResult.Errors[0].ErrorMessage);
    } 
}
