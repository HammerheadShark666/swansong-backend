using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData;

public class IdentityRoles
{
    public static List<IdentityRole> GetIdentityRoleDefaultData()
    {
        return new List<IdentityRole>()
        {
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "USER", NormalizedName = "USER".ToUpper() },
            new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "ADMIN", NormalizedName = "ADMIN".ToUpper() }
        };
    }
}