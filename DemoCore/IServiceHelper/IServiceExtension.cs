
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedisService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.IServiceHelper
{
    public static class IServiceExtension
    {
        
        public static IServiceCollection AddRedisService(this IServiceCollection service, IConfiguration Configuration)
        {
            //redis缓存
            var section = Configuration.GetSection("Redis:Default");
            //连接字符串
            string _connectionString = section.GetSection("Connection").Value;
            //实例名称
            string _instanceName = section.GetSection("InstanceName").Value;
            //默认数据库 
            int _defaultDB = int.Parse(section.GetSection("DefaultDB").Value ?? "0");
            return service.AddSingleton(new RedisHelper().Init(_connectionString, _instanceName, _defaultDB));
        }
    }
}
