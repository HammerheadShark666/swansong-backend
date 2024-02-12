using SwanSong.Domain;
using System;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData;

public class Accounts
{
    public static List<Account> GetAccountDefaultData()
    {
        return new List<Account>()
        {
            new Account
            {
                Id = 1,
                FirstName = "test",
                LastName = "test",
                Email = "Test100@hotmail.com",
                PasswordHash = "$2a$11$6J/RawAXn5hbcQwiVor7A.dEtLcMcUF8BI/EOMrAa2002hNJB8ZKC",
                AcceptTerms = false,
                Role = Domain.Helper.Enums.Role.SuperAdmin,
                Verified = new DateTime(),
                ResetToken = "142CEC560EBE8EA56F8344E178948EE76022B02B0D407A974611AFCDA7849FCD83826607543C0CA0",
                Created = new DateTime()
            }
        };
    }
}