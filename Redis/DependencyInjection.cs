using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Redis.Core;
using Redis.Core.Interfaces;
using Redis.Services;
using Redis.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redis
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRedisConfig(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("redis").Get<RedisConfiguration>();
            services.Configure<RedisConfiguration>(configuration.GetSection("redis"));

            services.AddDistributedRedisCache(options =>
            {
                options.Configuration = config.Host;
            });

            services.AddSingleton<IRedisConnectionFactory, RedisConnectionFactory>();
            services.AddSingleton<IRedisService, RedisService>();

            return services;
        }
    }
}
