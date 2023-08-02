using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.Model
{
    public class MenuModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("path")]
        public string Path { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("index")]
        public int Index { get; set; }
        [JsonProperty("isShow")]
        public bool IsShow { get; set; }

        public static List<(string title, string name,string path)> keyValuePairs = new List<(string title, string name, string path)>()
        {
                    ("系统首页","homeManager", "HomeManagerView"),
                    ("智能聊天","autoManager", "AutoManagerView"),
                    ("人员管理","caseManager","CaseManagerView"),
                    ("仓储管理","indexManager", "IndexManagerView"),
                    ("我的配置","myGroup","MyGroupView"),
                    ("关于","guanyumy","GuanyumyView")
        };
        public static List<MenuModel> GetDefaultMenus()
        {
            var models = new List<MenuModel>();
            var key = keyValuePairs.ToList();
            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                var model = new MenuModel();
                model.Icon = "";
                model.Index = i;
                model.IsShow = true;
                model.Title = key[i].title;
                model.Path = key[i].path;
                model.Name = key[i].name;
                models.Add(model);
            }
            return models;
        }
    }
}
