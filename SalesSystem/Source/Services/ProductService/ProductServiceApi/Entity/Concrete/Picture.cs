using ProductServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Entity.Concrete
{
    public class Picture:IEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
        public Picture(int productId):base()
        {
            ProductId = productId;
        }
        public Picture()
        {
            Date = DateTime.Now;
        }
    }
}
