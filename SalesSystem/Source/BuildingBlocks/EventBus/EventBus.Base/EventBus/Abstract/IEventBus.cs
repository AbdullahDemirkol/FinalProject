using EventBus.Base.Entity.Abstract;
using EventBus.Base.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.EventBus.Abstract
{
    public interface IEventBus : IDisposable
    {
        void Publish(IntegrationEvent integrationEvent);
        void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;
        void UnSubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationEventHandler<T>;


    }
}
