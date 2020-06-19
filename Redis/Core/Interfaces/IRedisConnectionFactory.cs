using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redis.Core.Interfaces
{
    public interface IRedisConnectionFactory
    {
        ConnectionMultiplexer Connection();
     }
}
