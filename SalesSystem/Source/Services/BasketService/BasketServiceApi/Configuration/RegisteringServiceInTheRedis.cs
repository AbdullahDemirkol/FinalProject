using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketServiceApi.Configuration
{
    public static class RegisteringServiceInTheRedis
    {
        public static ConnectionMultiplexer RegisterInRedis(this IServiceProvider services, IConfiguration configuration)
        {
            var redisConfig = ConfigurationOptions.Parse(configuration["RedisSettings:ConnectionString"], true);
            redisConfig.ResolveDns = true;

            return ConnectionMultiplexer.Connect(redisConfig);

        }
    }
}
