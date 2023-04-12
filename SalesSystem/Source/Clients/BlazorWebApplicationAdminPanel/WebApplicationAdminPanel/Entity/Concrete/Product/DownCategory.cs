using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete.Product
{
    public class DownCategory 
    {
        public int Id { get; set; }
        public int UpCategoryId{ get; set; }
        public UpCategory UpCategory { get; set; }
        public string DownCategoryName { get; set; }

    }
}
