using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

namespace WebApplicationAdminPanel.Entity.Concrete.DTOs
{
    public class UserDTO
    {
        public User.User UserModel { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
