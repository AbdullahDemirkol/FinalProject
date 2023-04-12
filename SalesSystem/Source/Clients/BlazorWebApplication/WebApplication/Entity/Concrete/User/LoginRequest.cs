using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entity.Concrete.User
{
    public class LoginRequest
    {
        public string UserName { get;  set; }
        public string Password { get;  set; }
        public LoginRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
