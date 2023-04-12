using OrderServiceApi.Entity.Concrete.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Order
{
    public class OrderItem : BaseEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public decimal UnitPrice { get; set; }
        public int Units { get; set; }

        public OrderItem(int productId, string productName, string pictureUrl, decimal unitPrice, int units)
        {
            ProductId = productId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            UnitPrice = unitPrice;
            Units = units;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();
            if (Units <= 0)
            {
                result.Add(new ValidationResult("Ürün adeti hatalı.", new[] { "Units" }));
            }
            return result;
        }
    }
}
