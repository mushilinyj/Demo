using DemoCore.AutoModule;
using DemoCore.CookieHelper;
using DemoCore.DTO;
using DemoCore.IServiceHelper;
using DemoCore.MD5Helper;
using DemoCore.Model;
using DemoCore.Validatetion;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NetMQ;
using NetMQ.Sockets;
using OpenAI_API.Completions;
using RedisService.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoCore.Controllers
{
    public class DemoController : BaseController
    {
        //[Autowired] 属性注入
        //public RedisHelper redisHelper { get; set; }
        [Autowired]
        public ICookieHelper CookieHelper { get; set; }

        [HttpGet]
        public async Task<APIReturn> Login(string userName, string password)
        {
            //var md5 = ToMD5.ToMd5(userName + ":" + password);
            var md5 = $"{userName}:{password}";
            //RedisHelper.Instance.SetStringKey(md5, userName + ":" + password, 300);
            //CookieHelper.SetCookie("usertoken", md5, 300);

            //claim: 可以理解为身份信息 姓名 密码等
            //claimsidentity: 可以理解为身份证
            //claimsprincipal: 可以理解为把身份证给到某个用户
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(userName, password));
            claims.Add(new Claim("special", "allow"));
            var identity = new ClaimsIdentity(claims,"user_token");
            await this.HttpContext.SignInAsync("user_token", new ClaimsPrincipal(identity));
            return new APIReturn().SetData(md5);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public APIReturn GetTest()
        {
            //var value = RedisHelper.Instance.GetStringKey(key);
            var indentity = this.HttpContext.User.Identities.Any(c => c.AuthenticationType == "user_token");
            if (indentity)
                return new APIReturn();
            return new APIReturn(1, false, "未认证");
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        //[AllowAnonymous]
        public APIReturn MenuList()
        {
            return new APIReturn().SetData(MenuModel.GetDefaultMenus());
        }
        [HttpPost]
        public APIReturn SetCookie(string key, string value)
        {
            CookieHelper.SetCookie(key, value,50);
            return new APIReturn();
        }
        [HttpGet]
        //[Authorize()]
        public async Task<Object> EventSourceDemo()
        {
            HttpContext.Response.ContentType = "text/event-stream";
            string str = "毛泽东思想是在中国革命艰难困苦时期创立的。1927年大革命失败，中国共产党经受了自创立以来从未有过的巨大挫折：共产党员和革命群众遭到反动派的疯狂屠杀，党员数量由大革命高潮时期的近6万人急剧减少到1万多人，党的活动被迫转入地下。毛泽东后来曾形象地比喻说：“被人家一巴掌打在地上，像一篮鸡蛋一样摔在地上，摔烂很多”。但是，以毛泽东同志为主要代表的中国共产党人，认真总结经验教训，深刻分析我国的实际情况，在实践中创造性地开辟了一条农村包围城市、武装夺取政权的中国革命道路，进而在理论上逐渐创立起了把马克思列宁主义的基本原理同中国革命的具体实际相结合的毛泽东思想毛泽东思想是在中国革命艰难困苦时期创立的。1927年大革命失败，中国共产党经受了自创立以来从未有过的巨大挫折：共产党员和革命群众遭到反动派的疯狂屠杀，党员数量由大革命高潮时期的近6万人急剧减少到1万多人，党的活动被迫转入地下。毛泽东后来曾形象地比喻说：“被人家一巴掌打在地上，像一篮鸡蛋一样摔在地上，摔烂很多”。但是，以毛泽东同志为主要代表的中国共产党人，认真总结经验教训，深刻分析我国的实际情况，在实践中创造性地开辟了一条农村包围城市、武装夺取政权的中国革命道路，进而在理论上逐渐创立起了把马克思列宁主义的基本原理同中国革命的具体实际相结合的毛泽东思想";
            var count = (str.Length / 20);

            for (int i = 0; i < count; i++)
            {
                string data =
                    $"id: {Guid.NewGuid():N} \n" +
                    $"retry: 1000\n" +
                    $"event: message\n" +
                    $"data: {str.Substring(i * 20, 20)}\n\n";
                var bitys = Encoding.UTF8.GetBytes(data);
                await HttpContext.Response.Body.WriteAsync(bitys);
                await HttpContext.Response.Body.FlushAsync();
                System.Threading.Thread.Sleep(2000);
            }
            var end = Encoding.UTF8.GetBytes("event: close\ndata: close\n\n");
            await HttpContext.Response.BodyWriter.WriteAsync(end);
            return null;
        }

        [HttpGet]
        public async Task<APIReturn> GptDemo()
        {
            var gpt = new OpenAI_API.OpenAIAPI("");

            //OpenAIService service = new OpenAIService(new OpenAiOptions() { ApiKey = "" });
            CompletionRequest createRequest = new CompletionRequest()
            {

                Prompt = "写一首关于工作的诗",
                Temperature = 0.3f,
                MaxTokens = 1000
            }; 
            HttpContext.Response.ContentType = "text/event-stream";
          
            await foreach (var result in gpt.Completions.StreamCompletionEnumerableAsync(createRequest))
            {
                string data =
                   $"id: {Guid.NewGuid():N} \n" +
                   $"retry: 1000\n" +
                   $"event: message\n" +
                   $"data: {result.Completions.First().Text}\n\n";
                   //$"data: {DateTime.Now:yyyy-MM-dd HH:mm:ss fff}\n\n";
                var bitys = Encoding.UTF8.GetBytes(data);

                await HttpContext.Response.Body.WriteAsync(bitys);
                await HttpContext.Response.Body.FlushAsync();
                System.Threading.Thread.Sleep(2000);
            }

            var end = Encoding.UTF8.GetBytes("event: close\ndata: close\n\n");
            await HttpContext.Response.BodyWriter.WriteAsync(end);
            return new APIReturn();
        }

        //[HttpGet]
        //public APIReturn FindAllCity()
        //{
        //    var list = CityService.FindAll();
        //    return new APIReturn().SetData(list);
        //}
        //[HttpGet]
        //public APIReturn FindOneCity(int id)
        //{
        //    var model = CityService.FindOneById(id);
        //    return new APIReturn().SetData(model);
        //}
        //[HttpPost]
        //public APIReturn CreateOne(string code, string name)
        //{
        //    var model = CityService.CreateOne(code, name);
        //    return new APIReturn().SetData(model);
        //}

        [HttpGet]
        public APIReturn GetCookie(string key)
        {
            var value = CookieHelper.GetCookie(key) ?? "无数据";
            return new APIReturn(0,true, value);
        }
        [HttpDelete]
        public APIReturn RemoveCookie(string key)
        {
            CookieHelper.DeleteCookie(key);
            return new APIReturn();
        }
        [HttpGet]
        public APIReturn NetMqTest(string message)
        {
            //发布端
            using (var pubSocket = new PublisherSocket())
            {
                pubSocket.Options.SendHighWatermark = 1000;
                pubSocket.Bind("tcp://127.0.0.1:12345");
                pubSocket.SendMoreFrame("demo").SendFrame(message);
            }
            return new APIReturn();
        }
    }
}
