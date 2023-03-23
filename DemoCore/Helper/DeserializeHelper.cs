using Newtonsoft.Json;

namespace DemoCore.Helper
{
    public static class DeserializeHelper
    {
        /// <summary>
        /// 使用JsonConvert 序列化对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(this object obj)
        {
            return JsonConvert.SerializeObject(obj);

        }

        public static string Serialize<T>(T obj) where T : class
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static string SerializeNotNull<T>(T obj) where T : class
        {
            var setting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };//序列化忽略null值
            return JsonConvert.SerializeObject(obj, setting);
        }
        /// <summary>
        /// 使用JsonConvert 反序列化对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static T DeserializeObject<T>(string str) where T : class
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
