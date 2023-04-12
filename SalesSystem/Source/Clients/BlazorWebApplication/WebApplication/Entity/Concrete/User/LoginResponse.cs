using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entity.Concrete.User
{
    public class LoginResponse
    {
        public string UserName { get; set; }
        public string UserToken { get; set; }
        public DateTime Expiration { get; set; }
    }
}
