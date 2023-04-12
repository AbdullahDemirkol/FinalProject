using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer
{
    public class PaymentMethod
    {
        public Guid Id { get; set; }
        public string Alias { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string SecurityNumber { get; set; }
        [Required]
        public string CardHolderName { get; set; }
        
        public DateTime Expiration { get; set; }
        [RegularExpression(@"(0[1-9]|1[0-2])\/[0-9]{2}", ErrorMessage = "Expiration should match a valid MM/YY value")]
        public string CardExpirationShort { get; set; }
        public int CardTypeId { get; set; }
        public bool Status { get; set; }
        public PaymentMethod()
        {

        }

        public PaymentMethod(string cardNumber, string securityNumber, string cardHolderName, string cardExpirationShort, int cardTypeId)
        {
            CardNumber = cardNumber;
            SecurityNumber = securityNumber;
            CardHolderName = cardHolderName;
            CardTypeId = cardTypeId;
            CardExpirationShort = cardExpirationShort;
        }
        public string CardExpirationShortFormat()
        {
            CardExpirationShort = Expiration.ToString("MM/yy");
            return CardExpirationShort;
        }
        public DateTime CardExpirationApiFormat()
        {
            var month = CardExpirationShort.Split('.')[0];
            var year = $"20{CardExpirationShort.Split('.')[1]}";
            Expiration = new DateTime(int.Parse(year), int.Parse(month), 1);
            return Expiration;
        }
    }
}
