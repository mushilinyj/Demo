using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore
{
    public class APIReturn
    {
        public int code { get; set; } = 0;

        public bool state { get; set; } = true;

        public string msg { get; set; } = "操作成功";

        public object data { get; set; }

        public APIReturn()
        { }
        public APIReturn(int code, bool state, string msg, object data)
        {
            this.code = code;
            this.state = state;
            this.msg = msg;
            this.data = data;
        }
        public APIReturn(int code, bool state, string msg)
        {
            this.code = code;
            this.state = state;
            this.msg = msg;
        }
        public APIReturn(int code, bool state)
        {
            this.code = code;
            this.state = state;
        }
        public APIReturn SetMsg(string msg)
        {
            this.msg = msg;
            return this;
        }
        public APIReturn SetData(object data)
        {
            this.data = data;
            return this;
        }
        public string ToJsonString()
        {
            return JsonConvert.SerializeObject(this);
        }
        public string ToJsonStringNoNull()
        {
            var setting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };//序列化忽略null值
            return JsonConvert.SerializeObject(this, setting);
        }
    }
}
