using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entity.Concrete.User;

namespace WebApplication.Entity.Concrete.DTOs
{
    public class UserDTO
    {
        public UserDTO()
        {
            Role = new Role();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfileImagePath { get; set; }
        public Role Role { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
    }
}
