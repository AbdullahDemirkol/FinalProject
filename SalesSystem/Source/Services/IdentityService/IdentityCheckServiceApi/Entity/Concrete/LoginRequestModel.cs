using IdentityCheckServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Entity.Concrete
{
    public class LoginRequestModel : IEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
