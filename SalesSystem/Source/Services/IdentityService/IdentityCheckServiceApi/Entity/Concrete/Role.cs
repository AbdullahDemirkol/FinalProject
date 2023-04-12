using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Entity.Concrete
{
    public class Role
    {
        public static Role User = new(1, nameof(User).ToLowerInvariant());
        public static Role Admin = new(2, nameof(Admin).ToLowerInvariant());
        public string Name { get; set; }
        public int Id { get; set; }


        public Role()
        {

        }
        public Role(int id, string roleName) 
        {
            Id = id;
            Name = roleName;
        }
        public static IEnumerable<Role> List()
        {
            return new List<Role> { User, Admin};
        }
        public static Role FromName(string name)
        {
            var state = List().SingleOrDefault(p => p.Name == name);
            return state;
        }
        public static Role FromId(int id)
        {
            var state = List().SingleOrDefault(p => p.Id == id);
            return state;
        }
    }
}
