using Newtonsoft.Json;

namespace DemoCore.Model
{
    public class SettingModel
    {
        [JsonProperty("connection")]
        public string Connection { get; set; }
        [JsonProperty("instanceName")]
        public string InstanceName { get; set; }
        [JsonProperty("defaultDB")]
        public int DefaultDB { get; set; }
    }
}
