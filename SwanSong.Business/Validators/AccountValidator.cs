using SwanSong.Data.Repository.Interfaces;
using SwanSong.Domain;

namespace SwanSong.Business.Validator;

public class AccountValidator : BaseValidator<Account>
{
    private readonly IAccountRepository _accountRepository;

    public AccountValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;

        RuleSet("BeforeSave", () => { 

        });

        RuleSet("AfterSave", () => { 

        });

        RuleSet("BeforeDelete", () => {
             
        });

        RuleSet("AfterDelete", () => { 

        });
    }
}
