using Microsoft.Extensions.Options;
using Redis.Core.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redis.Core
{
    public class RedisConnectionFactory : IRedisConnectionFactory
    {
        /// <summary>
        ///The _connection.
        /// </summary>
        private readonly Lazy<ConnectionMultiplexer> _connection;

        private readonly IOptions<RedisConfiguration> _redis;

        public RedisConnectionFactory(IOptions<RedisConfiguration> redis)
        {
            this._redis = redis;
            this._connection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(this._redis.Value.Host));
        }

        public ConnectionMultiplexer Connection()
        {
            return this._connection.Value;
        }
    }
}
