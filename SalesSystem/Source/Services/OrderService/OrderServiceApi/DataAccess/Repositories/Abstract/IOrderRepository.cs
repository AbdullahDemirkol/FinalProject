using OrderServiceApi.Entity.Concrete.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.DataAccess.Repositories.Abstract
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
    }
}
