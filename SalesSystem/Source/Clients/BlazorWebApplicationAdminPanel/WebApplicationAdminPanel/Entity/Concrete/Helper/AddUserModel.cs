using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

namespace WebApplicationAdminPanel.Entity.Concrete.Helper
{
    public class AddUserModel
    {
        public UserDTO UserModel { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
