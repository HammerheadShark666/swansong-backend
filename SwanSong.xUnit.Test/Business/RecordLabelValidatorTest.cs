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

public class RecordLabelValidatorTest
{
    private Mock<IRecordLabelRepository> recordLabelRepositoryMock;
    private IValidator<RecordLabel> validator;

    private static readonly RecordLabel newRecordLabel = new() { Id = 0, Name = "Test RecordLabel 1" };
    private static readonly RecordLabel existingRecordLabel = new() { Id = 1, Name = "Test RecordLabel 1" };
             
    public RecordLabelValidatorTest()
    {
        recordLabelRepositoryMock = new Mock<IRecordLabelRepository>();
        validator = new RecordLabelValidator(recordLabelRepositoryMock.Object);
    }

    [Fact]
    public async void Before_save_validate_record_label_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingRecordLabel);
        Assert.True(validation.IsValid);
    }

    [Fact]
    public async void After_save_validate_record_label_return_true()
    {
        ValidationResult validation = await validator.ValidateAsync(existingRecordLabel, options => options
                                                                                .IncludeRuleSets("AfterSave"));
        Assert.False(validation.IsValid);
        Assert.Equal("The record label has been saved.", validation.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_record_label_name_null_return_false()
    {
        RecordLabel recordLabel = new() { Id = 1, Name = "" };
        ValidationResult validationResult = await validator.ValidateAsync(recordLabel, options => options
                                                                                .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name is required.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_record_label_name_empty_return_false()
    {
        RecordLabel recordLabel = new() { Id = 1, Name = "" };
        ValidationResult validationResult = await validator.ValidateAsync(recordLabel, options => options
                                                                                .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Equal(2, validationResult.Errors.Count);
        Assert.Equal("Name length between 1 and 100.", validationResult.Errors[1].ErrorMessage);
    }

    [Fact]
    public async void Before_save_validate_record_label_name_over_100_characters_empty_return_false()
    {
        RecordLabel recordLabel = new() { Id = 1, Name = UnitTestHelper.generateRandomString(101) };
        ValidationResult validationResult = await validator.ValidateAsync(recordLabel, options => options
                                                                                .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Name length between 1 and 100.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_insert_save_validate_record_label_insert_name_duplicate_return_false()
    {
        RecordLabel recordLabel = new() { Id = 0, Name = "Test Label" };

        recordLabelRepositoryMock.Setup(p => p.ExistsAsync("Test Label")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(recordLabel, options => options
                                                                                .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Label already exists.", validationResult.Errors[0].ErrorMessage);
    }

    [Fact]
    public async void Before_update_save_validate_record_label_update_name_duplicate_return_false()
    {
        RecordLabel recordLabel = new() { Id = 1, Name = "Test Label" };

        recordLabelRepositoryMock.Setup(p => p.ExistsAsync(1, "Test Label")).Returns(Task.FromResult(true));

        ValidationResult validationResult = await validator.ValidateAsync(recordLabel, options => options
                                                                                .IncludeRuleSets("BeforeSave"));

        Assert.False(validationResult.IsValid);
        Assert.Single(validationResult.Errors);
        Assert.Equal("Test Label already exists.", validationResult.Errors[0].ErrorMessage);
    } 
}
