using IdentityCheckServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Entity.Concrete
{
    public class LoginResponseModel : IEntity
    {
        public string Username { get; set; }
        public string UserToken { get; set; }
        public string RoleName { get; set; }
        public DateTime Expiration { get; set; }
    }
}
