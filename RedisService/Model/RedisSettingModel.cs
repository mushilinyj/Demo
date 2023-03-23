using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisService.Model
{
    public class RedisSettingModel
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        [JsonProperty("connection")]
        public string Connection { get; set; }
        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("instanceName")]
        public string InstanceName { get; set; }
        /// <summary>
        /// 默认数据库
        /// </summary>
        [JsonProperty("defaultDB")]
        public int DefaultDB { get; set; }
    }
}
