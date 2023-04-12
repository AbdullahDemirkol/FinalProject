using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Entity.Concrete
{
    public class SubscriptionInfo
    {
        public SubscriptionInfo(Type handlerType)
        {
            HandlerType = handlerType ?? throw new ArgumentNullException(nameof(handlerType));
        }

        public Type HandlerType { get; }

        internal static SubscriptionInfo SetType(Type handlerType)
        {
            return new SubscriptionInfo(handlerType);
        }
    }
}
