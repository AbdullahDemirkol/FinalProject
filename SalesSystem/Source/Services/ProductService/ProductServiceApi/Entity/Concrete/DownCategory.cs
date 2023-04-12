using ProductServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Entity.Concrete
{
    public class DownCategory : IEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("UpCategory")]
        public int UpCategoryId{ get; set; }
        public UpCategory UpCategory { get; set; }
        [Required]
        public string DownCategoryName { get; set; }

    }
}
