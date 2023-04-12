using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAdminPanel.Entity.Concrete
{
    public class BasketDTO
    {
        public BasketDTO(string city, string street, string state, string country, string zipCode, string cardNumber, string cardHolderName, string cardExpirationSort, DateTime cardExpiration, string cardSecurityNumber, int cardTypeId, string buyerName)
        {
            City = city;
            Street = street;
            State = state;
            Country = country;
            ZipCode = zipCode;
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            CardExpirationSort = cardExpirationSort;
            CardExpiration = cardExpiration;
            CardSecurityNumber = cardSecurityNumber;
            CardTypeId = cardTypeId;
            BuyerName = buyerName;
        }
        public BasketDTO()
        {

        }

        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
        public string ZipCode { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string CardHolderName { get; set; }
        [Required]
        public string CardExpirationSort { get; set; }
        [Required]
        public DateTime CardExpiration { get; set; }
        [Required]
        public string CardSecurityNumber { get; set; }
        public int CardTypeId { get; set; }
        public string BuyerName { get; set; }

    }
}
