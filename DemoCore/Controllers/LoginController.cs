using DemoCore.AutoModule;
using DemoCore.DTO;
using DemoCore.IServiceHelper;
using DemoCore.Validatetion;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;

namespace DemoCore.Controllers
{
    public class LoginController : BaseController
    {
        [Autowired]
        public IAuthenticateService AuthenticateService { get; set; }
        [HttpPost]
        [AllowAnonymous]
        public APIReturn Index(LoginRequestDTO request)
        {
            //var ser = HttpContext.RequestServices.GetService<AuthenticateService>();
            var valid = ValidatetionHelper.IsValid(request);
            if (!valid.IsVaild)
            {
                return new APIReturn(1, false, "", valid);
            }
            var token = string.Empty;
            var result = AuthenticateService.IsAuthenticated(request, out token);
            if (!result)
                return new APIReturn(1, false, "获取登录唯一token失败");
            return new APIReturn(0, true, "", token);
        }
        [HttpGet]
        [AllowAnonymous]
        public APIReturn SayHello()
        {
            return new APIReturn(0, true, "hello world");
        }
    }
}
