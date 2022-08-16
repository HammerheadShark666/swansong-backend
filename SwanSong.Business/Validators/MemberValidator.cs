using FluentValidation;
using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;
using System;
using System.Threading.Tasks;

namespace SwanSong.Business.Validator
{
    public class MemberValidator : BaseValidator<Member>
    {
        private readonly IMemberRepository _artistMemberRepository;

        public MemberValidator(IMemberRepository artistMemberRepository)
        {
            _artistMemberRepository = artistMemberRepository;

            RuleSet("BeforeSave", () => {
                           
                RuleFor(member => member.StageName) 
                    .NotEmpty().WithMessage("Stage name is required.")
                    .Length(1, 150).WithMessage("Stage name length between 1 and 150.");

                RuleFor(member => member).MustAsync(async (member, cancellation) => {
                    return await MemberNameExists(member);
                }).WithMessage(member => $"{member.StageName} already exists.");

                RuleFor(member => member.Surname)
                    .Length(0, 50)
                    .WithMessage("Surname must be 50 characters or less.");

                RuleFor(member => member.MiddleName)
                    .Length(0, 50)
                    .WithMessage("Middle name must be 50 characters or less.");

                RuleFor(member => member.FirstName)
                    .Length(1, 50)
                    .WithMessage("First name must be 50 characters or less.");

                RuleFor(member => member.DateOfBirth)
                    .GreaterThan(new DateTime(1900, 1, 1));

                RuleFor(member => member.DateOfDeath)
                    .GreaterThan(m => m.DateOfBirth)
                    .WithMessage("Date of death must be after date of birth.");

                RuleFor(member => member.DateOfDeath)
                    .GreaterThan(new DateTime(1900, 1, 1));
            });

            RuleSet("AfterSave", () =>
            {
                RuleFor(member => member) 
                    .Null() 
                    .WithSeverity(Severity.Info)
                    .WithMessage("The member has been saved.");
            });
             
            RuleSet("BeforeDelete", () => { });

            RuleSet("AfterDelete", () => {

                RuleFor(studio => studio)
                    .Null()
                    .WithSeverity(Severity.Info)
                    .WithMessage("The member has been deleted.");
            });
        }

        protected async Task<bool> MemberNameExists(Member member)
        {
            return member.Id == 0
                ? !(await _artistMemberRepository.ExistsAsync(member.Id, member.StageName))
                : !(await _artistMemberRepository.ExistsAsync(member.Id, member.ArtistId, member.StageName));
        }
    }
}
