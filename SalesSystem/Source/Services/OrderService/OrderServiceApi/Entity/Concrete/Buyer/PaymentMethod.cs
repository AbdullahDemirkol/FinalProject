using OrderServiceApi.Entity.Concrete.Base;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using OrderServiceApi.Entity.Concrete.Helper.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Buyer
{
    public class PaymentMethod : BaseEntity
    {
        //[NoMapping]
        //[NotMapped]
        //public Buyer Buyer { private get; set; }
        public string Alias { get; set; }
        //public Guid BuyerId{ get; set; }
        public string CardNumber { get; set; }
        public string SecurityNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime Expiration { get; set; }
        public int CardTypeId { get; set; }
        public CardType CardType { get; private set; }
        public bool Status { get; set; }
        public Guid BuyerId { get; set; }

        public PaymentMethod()
        {
            Id = Guid.NewGuid();
        }
        public PaymentMethod(string alias, string cardNumber, string securityNumber, string cardHolderName, DateTime expiration, int cardTypeId/*,Guid buyerId*/):this()
        {
            CardNumber = !string.IsNullOrWhiteSpace(cardNumber) ? cardNumber : throw new OrderingDomainException(nameof(cardNumber));
            SecurityNumber = !string.IsNullOrWhiteSpace(securityNumber) ? securityNumber : throw new OrderingDomainException(nameof(securityNumber));
            CardHolderName = !string.IsNullOrWhiteSpace(cardHolderName) ? cardHolderName : throw new OrderingDomainException(nameof(cardHolderName));

            if (expiration < DateTime.UtcNow)
            {
                throw new OrderingDomainException(nameof(expiration));
            }
            Alias = alias;
            Expiration = expiration;
            CardTypeId = cardTypeId;
            Status = true;
            //BuyerId = buyerId;
        }
        public bool IsEqualPaymentMethod(int cardTypeId, string cardNumber, string cardHolderName, DateTime expiration)
        {
            return CardTypeId == cardTypeId && CardNumber == cardNumber && CardHolderName == cardHolderName && Expiration == expiration ;
        }
    }
}
