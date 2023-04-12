using EventBus.Base.Entity.Abstract;
using EventBus.Base.Entity.Concrete;
using EventBus.Base.EventBus.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.EventBus.Concrete
{
    class EventBusSubscriptionInMemoryManager : IEventBusSubscriptionService
    {
        private readonly Dictionary<string, List<SubscriptionInfo>> _handlers;
        private readonly List<Type> _eventTypes;

        public Func<string, string> _eventNameGetter;
        public event EventHandler<string> OnEventRemoved;

        public EventBusSubscriptionInMemoryManager(Func<string, string> eventNameGetter)
        {
            _handlers = new Dictionary<string, List<SubscriptionInfo>>();
            _eventTypes = new List<Type>();
            _eventNameGetter = eventNameGetter;
        }

        public void AddSubscriptionEvent<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            var eventName = GetEventKey<T>();
            var x = typeof(T);
            AddSubscriptionEvent(typeof(TH), eventName);

            if (!_eventTypes.Contains(typeof(T)))
            {
                _eventTypes.Add(typeof(T));
            }
        }
        private void AddSubscriptionEvent(Type type, string eventName)
        {
            if (!HasSubscriptionsForEvent(eventName))
            {
                _handlers.Add(eventName, new List<SubscriptionInfo>());
            }
            if (_handlers[eventName].Any(p => p.HandlerType == type))
            {
                throw new ArgumentException($"Handler Type {type.Name} already registered for '{eventName}'", nameof(type));
            }
            _handlers[eventName].Add(SubscriptionInfo.SetType(type));
        }


        public void RemoveSubscriptionEvent<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            var eventName = GetEventKey<T>();
            var HandlerToRemove = FindSubscriptionToRemove<T, TH>();
            RemoveHandler(HandlerToRemove, eventName);
        }
        private SubscriptionInfo FindSubscriptionToRemove<T, TH>()
            where T : IntegrationEvent
            where TH : IIntegrationEventHandler<T>
        {
            var eventName = GetEventKey<T>();
            return FindSubscriptionToRemove(eventName, typeof(TH));
        }
        private SubscriptionInfo FindSubscriptionToRemove(string eventName, Type type)
        {
            if (!HasSubscriptionsForEvent(eventName))
            {
                return null;
            }
            return _handlers[eventName].SingleOrDefault(p => p.HandlerType == type);
        }
        private void RemoveHandler(SubscriptionInfo handlerToRemove, string eventName)
        {
            if (handlerToRemove != null)
            {
                _handlers[eventName].Remove(handlerToRemove);
                if (!_handlers[eventName].Any())
                {
                    _handlers.Remove(eventName);
                    var eventType = _eventTypes.SingleOrDefault(p => p.Name == eventName);
                    if (eventType != null)
                    {
                        _eventTypes.Remove(eventType);
                    }
                    RaiseOnEventRemoved(eventName);
                }
            }
        }
        private void RaiseOnEventRemoved(string eventName)
        {
            var handler = OnEventRemoved;
            handler?.Invoke(this, eventName);
        }


        public bool IsEmpty => !_handlers.Keys.Any();
        public void Clear() => _handlers.Clear();


        public string GetEventKey<T>()
        {
            string eventName = typeof(T).Name;
            return _eventNameGetter(eventName);
        }
        public Type GetEventTypeByName(string eventName)
        {
            return _eventTypes.SingleOrDefault(p => p.Name == eventName);
        }
        public IEnumerable<SubscriptionInfo> GetHandlerForEvent<T>() where T : IntegrationEvent
        {
            var eventName = GetEventKey<T>();
            return GetHandlerForEvent(eventName);
        }
        public IEnumerable<SubscriptionInfo> GetHandlerForEvent(string eventName)
        {
            return _handlers[eventName];
        }


        public bool HasSubscriptionsForEvent<T>() where T : IntegrationEvent
        {
            var key = GetEventKey<T>();
            return HasSubscriptionsForEvent(key);
        }
        public bool HasSubscriptionsForEvent(string eventName)
        {
            var key = _handlers.ContainsKey(eventName);
            return key;
        }

    }
}
