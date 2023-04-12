using MediatR;
using OrderServiceApi.Entity.Concrete.Buyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.IntegrationEvents.QueriesFeatures.Command.RequestCommandModel
{
    public class AddPaymentMethodCommand: IRequest<(bool, string)>
    {
        public PaymentMethod PaymentMethod { get; set; }
        public string UserName { get; set; }
        public AddPaymentMethodCommand(PaymentMethod paymentMethod, string userName)
        {
            PaymentMethod = paymentMethod;
            UserName = userName;
        }
    }
}
