using IdentityCheckServiceApi.DataAccess;
using IdentityCheckServiceApi.Entity.Concrete;
using IdentityCheckServiceApi.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Extensions.Migration.MigrationSeeds
{
    public class IdentityCheckContextSeed
    {
        public static async Task SeedAsync(IdentityCheckContext identityContext)
        {
            if (identityContext.Roles.Count() == 0)
            {
                identityContext.Roles.AddRange(GetDefaultRoles());
                await identityContext.SaveChangesAsync();
            }
            if (identityContext.Users.Count() == 0)
            {
                identityContext.Users.AddRange(GetDefaultUsers(identityContext));
                await identityContext.SaveChangesAsync();
            }


        }
        private static IEnumerable<Role> GetDefaultRoles()
        {
            IEnumerable<Role> roles = Role.List();
            return roles;
        }
        private static IEnumerable<UserModel> GetDefaultUsers(IdentityCheckContext identityContext)
        {
            IEnumerable<UserModel> users = new List<UserModel>()
            {
                new UserModel()
                {
                    Username="user1",
                    Password=HashingHelper.SHA512("pass1"),
                    FirstName="Birinci",
                    LastName="Kullanıcı",
                    Email="birincikullanici@gmail.com",
                    Phone="(555) 444 33 22",
                    Role=identityContext.Roles.FirstOrDefault(p=>p.Name==Role.User.Name),
                    Status=true
                },
                new UserModel()
                {
                    Username="user2",
                    Password=HashingHelper.SHA512("pass2"),
                    FirstName="İkinci",
                    LastName="Kullanıcı",
                    Email="ikincikullanici@gmail.com",
                    Phone="(555) 666 77 88",
                    Role=identityContext.Roles.FirstOrDefault(p=>p.Name==Role.User.Name),
                    Status=true
                },
                new UserModel()
                {
                    Username="user3",
                    Password=HashingHelper.SHA512("pass3"),
                    FirstName="Üçüncü",
                    LastName="Kullanıcı",
                    Email="üçüncükullanici@gmail.com",
                    Phone="(555) 999 11 33",
                    Role=identityContext.Roles.FirstOrDefault(p=>p.Name==Role.User.Name),
                    Status=true
                },
                new UserModel()
                {
                    Username="admin",
                    Password=HashingHelper.SHA512("admin"),
                    FirstName="Admin",
                    LastName="Kullanıcısı",
                    Email="üçüncükullanici@gmail.com",
                    Phone="(555) 999 11 33",
                    Role=identityContext.Roles.FirstOrDefault(p=>p.Name==Role.Admin.Name),
                    Status=true
                }

            };
            return users;
        }
    }
}
