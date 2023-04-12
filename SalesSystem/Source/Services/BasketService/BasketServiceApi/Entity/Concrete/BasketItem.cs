using BasketServiceApi.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Entity.Concrete
{

    public class BasketItem : IValidatableObject,IEntity
    {
        public string Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal OldUnitPrice { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (Quantity < 1)
            {
                results.Add(new ValidationResult("Birim Sayısı Hatalı.", new[] { "Quantity" }));
            }
            return results;
        }
    }
}
