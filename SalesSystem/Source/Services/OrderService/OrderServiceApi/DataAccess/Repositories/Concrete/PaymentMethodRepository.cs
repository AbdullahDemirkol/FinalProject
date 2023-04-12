using OrderServiceApi.DataAccess.Repositories.Abstract;
using OrderServiceApi.Entity.Concrete.Buyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess.Repositories.Concrete
{
    public class PaymentMethodRepository:GenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(OrderDbContext orderDbContext) : base(orderDbContext)
        {
        }

        //public async Task<PaymentMethod> AddPaymentMethod(PaymentMethod paymentMethod)
        //{
        //    await _orderDbContext.PaymentMethods.AddAsync(paymentMethod);
        //    return paymentMethod;
        //}

        //public List<PaymentMethod> GetPaymentMethodsByBuyerIdAsync(Guid buyerId)
        //{
        //    var paymentMethods = _orderDbContext.PaymentMethods.Where(p => p.BuyerId == buyerId).ToList();
        //    return paymentMethods;
        //}
    }
}
