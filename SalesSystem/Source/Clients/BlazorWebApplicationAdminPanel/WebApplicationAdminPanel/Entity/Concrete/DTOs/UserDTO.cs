using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Entity.Concrete.User;

namespace WebApplicationAdminPanel.Entity.Concrete.DTOs
{
    public class UserDTO
    {
        public UserDTO()
        {

        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Role Role { get; set; }
        public bool Status { get; set; }
    }
}
