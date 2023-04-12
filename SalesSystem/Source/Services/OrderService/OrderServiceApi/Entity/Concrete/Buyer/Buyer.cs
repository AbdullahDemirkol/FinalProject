using OrderServiceApi.DataAccess;
using OrderServiceApi.Entity.Concrete.Base;
using OrderServiceApi.IntegrationEvents.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Entity.Concrete.Buyer
{
    public class Buyer : BaseEntity
    {
        public string Name { get; set; }
        public List<PaymentMethod> _paymentMethods { get; set; }
        //public PaymentMethod paymentMethod => _paymentMethods;
        protected Buyer()
        {
            _paymentMethods = new List<PaymentMethod>();
        }

        public Buyer(string name) : this()
        {
            Id = Guid.NewGuid();
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        public (bool,PaymentMethod) VerifyOrAddPaymentMethod(OrderStartedDomainEvent orderStartedDomainEvent/*,List<PaymentMethod> paymentMethodsByBuyer*/, int cardTypeId, string alias)
        {
            bool responseInsert = false;
            try
            {
                foreach (var _paymentMethod in _paymentMethods)
                {
                    bool equalPaymentMethod = _paymentMethod.IsEqualPaymentMethod(cardTypeId, orderStartedDomainEvent.CardNumber, orderStartedDomainEvent.CardHolderName, orderStartedDomainEvent.CardExpiration);
                    
                    if (equalPaymentMethod)
                    {
                        AddDomainEvent(new BuyerAndPaymentVerifiedDomainEvent(this, _paymentMethod, orderStartedDomainEvent.Order.Id));
                        return (responseInsert,_paymentMethod);
                    }
                }
                var _newPaymentMethod = new PaymentMethod(alias, orderStartedDomainEvent.CardNumber, orderStartedDomainEvent.CardSecurityNumber, orderStartedDomainEvent.CardHolderName, orderStartedDomainEvent.CardExpiration, cardTypeId);
                _paymentMethods.Add(_newPaymentMethod);
                AddDomainEvent(new BuyerAndPaymentVerifiedDomainEvent(this, _newPaymentMethod, orderStartedDomainEvent.Order.Id));
                responseInsert = true;
                return (true, _newPaymentMethod);

            }
            catch (Exception e)
            {

                throw new Exception($"error {e.Message}");
            }
        }
    }
}
