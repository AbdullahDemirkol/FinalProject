using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entity.Concrete.User
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Role()
        {

        }
        public Role(int id, string roleName) 
        {
            Id = id;
            Name = roleName;
        }
        //public static Role FromName(string name)
        //{
        //    var state = List().SingleOrDefault(p => p.Name == name);
        //    return state;
        //}
        //public static Role FromId(int id)
        //{
        //    var state = List().SingleOrDefault(p => p.Id == id);
        //    return state;
        //}
    }
}
