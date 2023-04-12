using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Entity.Concrete.Enum
{
    public enum EventBusType
    {
        RabbitMQ = 0,
        AzureServiceBus = 1
    }
}
