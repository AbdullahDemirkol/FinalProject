using MediatR;
using OrderServiceApi.DataAccess;
using OrderServiceApi.Entity.Concrete.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceApi.Extensions.Mediator
{
    public static class MediatorExtension
    {
        public static async Task DispatchDomainEventsAsnyc(this IMediator mediator, OrderDbContext orderDbContext)
        {
            var domainEntities = orderDbContext.ChangeTracker
                .Entries<BaseEntity>()
                .Where(p => p.Entity.DomainEvents != null && p.Entity.DomainEvents.Any());
            var domainEvents = domainEntities
                .SelectMany(p => p.Entity.DomainEvents)
                .ToList();
            domainEntities.ToList()
                .ForEach(entity => entity.Entity.ClearDomainEvent());
            foreach (var domainEvent in domainEvents)
            {
                await mediator.Publish(domainEvent);
            }
        }
    }
}
