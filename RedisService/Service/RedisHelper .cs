using Newtonsoft.Json;
using RedisService.Model;
using StackExchange.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisService.Service
{
    public class RedisHelper : IDisposable
    {
        private string _connectionString;
        private string _instanceName;
        private int _defaultDB;
        IDatabase _db;
        ConnectionMultiplexer _connection;
        private ConcurrentDictionary<string, ConnectionMultiplexer> _connections;

        public RedisHelper()
        {
        }

        private static Lazy<RedisHelper> _instance = new Lazy<RedisHelper>(() =>
        {
            return new RedisHelper();
        });
        public static RedisHelper Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        public RedisHelper Init(RedisSettingModel settingModel)
        {
            _connectionString = settingModel.Connection;
            _instanceName = settingModel.InstanceName;
            _defaultDB = settingModel.DefaultDB;
            _connections = new ConcurrentDictionary<string, ConnectionMultiplexer>();
            _connection = _connections.GetOrAdd(_instanceName, p => ConnectionMultiplexer.Connect(_connectionString));
            _db = _connection.GetDatabase(_defaultDB);
            return this;
        }
        public IDatabase GetDatabase()
        {
            return _connection.GetDatabase(_defaultDB);
        }
        public IServer GetServer(string configName = null, int endPointsIndex = 0)
        {
            var confOption = ConfigurationOptions.Parse(_connectionString);
            return _connection.GetServer(confOption.EndPoints[endPointsIndex]);
        }

        /// <summary>
        /// 订阅
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public ISubscriber GetSubscriber(string configName = null)
        {
            return _connection.GetSubscriber();
        }

        #region 通用key操作
        /// <summary>
        /// 判断键是否存在
        /// </summary>
        public bool ExistsKey(string key)
        {
            return _db.KeyExists(key);
        }

        /// <summary>
        /// 删除键
        /// </summary>
        public bool DeleteKey(string key)
        {
            return _db.KeyDelete(key);
        }
        #endregion

        #region string操作
        /// <summary>
        /// 保存单个key value
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="expiry">过期时间 秒</param>
        public bool SetStringKey(string key, string value, long expiry = 0)
        {
            TimeSpan  time = expiry > 0 ? TimeSpan.FromSeconds(expiry) : default(TimeSpan);
            return _db.StringSet(key, value, time);
        }

        /// <summary>
        /// 获取单个key的值
        /// </summary>
        public RedisValue GetStringKey(string key)
        {
            return _db.StringGet(key);
        }
        /// <summary>
        /// 保存一个对象
        /// </summary>
        /// <typeparam name="T">对象的类型</typeparam>
        public bool SetStringKey<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?))
        {
            string json = JsonConvert.SerializeObject(obj);
            return _db.StringSet(key, json, expiry);
        }
        /// <summary>
        /// 获取一个key的对象
        /// </summary>
        /// <typeparam name="T">返回类型</typeparam>
        public T GetStringKey<T>(string key)
        {
            RedisValue value = _db.StringGet(key);
            if (value.IsNullOrEmpty)
            {
                return default;
            }
            return JsonConvert.DeserializeObject<T>(value);
        }
        /// <summary>
        /// 将给定 key 的值设为 value ，并返回 key 的旧值(old value)。
        /// </summary>
        /// <param name="key"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public string GetSetKet(string key, string newValue)
        {
            var oldValue = _db.StringGetSet(key, newValue);
            return oldValue;
        }
        #endregion

        #region set(集合)操作


        #endregion
        #region zset有序集合

        #endregion
        #region 链表

        #endregion
        #region hash

        #endregion
        public void Dispose()
        {
            if (_connections != null && _connections.Count > 0)
            {
                _connections.ToList().ForEach(item =>
                {
                    item.Value.Close();
                });
            }
        }
    }
}
