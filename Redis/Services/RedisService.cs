using Redis.Core.Interfaces;
using Redis.Services.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redis.Services
{
    public class RedisService : IRedisService
    {
        internal readonly IDatabase Db;
        protected readonly IRedisConnectionFactory ConnectionFactory;

        public RedisService(IRedisConnectionFactory connectionFactory)
        {
            this.ConnectionFactory = connectionFactory;
            this.Db = this.ConnectionFactory.Connection().GetDatabase();
        }

        public IDatabase GetDataBase()
        {
            return this.Db;
        }
    }
}
