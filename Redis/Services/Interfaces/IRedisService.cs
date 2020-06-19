using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Redis.Services.Interfaces
{
    public interface IRedisService
    {
        public IDatabase GetDataBase();
    }
}
