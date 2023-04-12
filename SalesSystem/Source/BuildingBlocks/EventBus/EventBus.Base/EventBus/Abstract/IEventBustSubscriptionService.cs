using EventBus.Base.Entity.Abstract;
using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.EventBus.Abstract
{
    public interface IEventBusSubscriptionService
    {
        bool IsEmpty { get; }
        event EventHandler<string> OnEventRemoved;
        void AddSubscriptionEvent<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        void RemoveSubscriptionEvent<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        bool HasSubscriptionsForEvent<T>() where T : IntegrationEvent;
        bool HasSubscriptionsForEvent(string eventName);
        Type GetEventTypeByName(string eventName);
        void Clear();
        IEnumerable<SubscriptionInfo> GetHandlerForEvent<T>() where T : IntegrationEvent;
        IEnumerable<SubscriptionInfo> GetHandlerForEvent(string eventName);
        string GetEventKey<T>();
    }
}
