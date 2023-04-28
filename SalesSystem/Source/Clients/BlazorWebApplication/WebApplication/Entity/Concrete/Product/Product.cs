using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Entity.Concrete.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Picture> Pictures { get; set; }
        public int UpCategoryId { get; set; }
        public UpCategory UpCategory { get; set; }
        public int DownCategoryId { get; set; }
        public DownCategory DownCategory { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public Product()
        {

        }

    }
}
