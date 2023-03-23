
using DemoCore.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RedisService.Model;
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
            var section = DeserializeHelper.DeserializeObject<RedisSettingModel>(Configuration.GetSection("Redis:Work").Value);
            return service.AddSingleton(new RedisHelper().Init(section));
        }
    }
}
