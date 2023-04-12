using ProductServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Entity.Concrete
{

    public class Product : IEntity
    {

        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [ForeignKey("UpCategory")]
        public int UpCategoryId { get; set; }
        public UpCategory UpCategory { get; set; }
        [Required]
        [ForeignKey("DownCategory")]
        public int DownCategoryId { get; set; }
        public DownCategory DownCategory { get; set; }
        [Required]
        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Picture> Pictures { get; set; }

    }
}
