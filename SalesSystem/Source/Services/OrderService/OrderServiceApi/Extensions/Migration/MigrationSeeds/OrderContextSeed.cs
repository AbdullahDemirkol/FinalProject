using OrderServiceApi.DataAccess;
using OrderServiceApi.Entity.Concrete.Helper.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Extensions.Migration.MigrationSeeds
{
    public class OrderContextSeed
    {

        public static async Task SeedAsync(OrderDbContext orderDbContext)
        {
            if (orderDbContext.OrderStatuses.Count() == 0)
            {
                orderDbContext.OrderStatuses.AddRange(GetDefaultOrderStatus());
                await orderDbContext.SaveChangesAsync();
            }

            if (orderDbContext.CardTypes.Count() == 0)
            {
                orderDbContext.CardTypes.AddRange(GetDefaultCardTypes());
                await orderDbContext.SaveChangesAsync();
            }

        }

        private static IEnumerable<CardType> GetDefaultCardTypes()
        {
            IEnumerable<CardType> cardTypes = CardType.List();
            return cardTypes;
        }

        private static IEnumerable<OrderStatus> GetDefaultOrderStatus()
        {
            IEnumerable<OrderStatus> orderStatuses = OrderStatus.List();
            return orderStatuses;
        }
    }
}
