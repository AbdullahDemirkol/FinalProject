using MediatR;
using OrderServiceApi.Entity.Concrete.Buyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel
{
    public class UpdatePaymentMethodCommand : IRequest<(bool, string)>
    {
        public Guid PaymentMethodId { get; set; }
        public int CardTypeId { get; set; }
        public UpdatePaymentMethodCommand(Guid paymentMethodId, int cardTypeId)
        {
            PaymentMethodId = paymentMethodId;
            CardTypeId = cardTypeId;
        }
    }
}
