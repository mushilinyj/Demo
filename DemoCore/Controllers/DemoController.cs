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
using RedisService.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
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
        [Autowired]
        public IAuthenticateService AuthenticateService { get; set; }
     
        [HttpPost]
        public APIReturn GetToken(LoginRequestDTO request) 
        {
            var valid = ValidatetionHelper.IsValid(request);
            if (!valid.IsVaild)
            {
                return new APIReturn(1, false, "", valid);
            }
            var token = string.Empty;
            var result = AuthenticateService.IsAuthenticated(request,out token);
            if (!result)
                return new APIReturn(1, false, "获取登录唯一token失败");
            return new APIReturn(0, true, "", token);
        }
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
            var value = CookieHelper.GetCookie(key);
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
