using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore.AuthorizationHelper
{
    public class PolicyRequirement : IAuthorizationRequirement
    {

    }

    //public class HandleRequirement : AuthorizationHandler<PolicyRequirement>
    //{
    //    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PolicyRequirement requirement)
    //    {
    //        var httpContext = (context.Resource as AuthorizationFilterContext).HttpContext;

    //        //获取授权方式
    //        var defaultAuthenticate = await Schemes.GetDefaultAuthenticateSchemeAsync();
    //        if (defaultAuthenticate != null)
    //        {
    //            //验证签发的用户信息
    //            var result = await httpContext.AuthenticateAsync(defaultAuthenticate.Name);
    //            if (result.Succeeded)
    //            {
    //                //判断是否为已停用的 Token
    //                if (!await _jwtApp.IsCurrentActiveTokenAsync())
    //                {
    //                    context.Fail();
    //                    return;
    //                }

    //                httpContext.User = result.Principal;

    //                //判断角色与 Url 是否对应
    //                //
    //                var url = httpContext.Request.Path.Value.ToLower();
    //                var role = httpContext.User.Claims.Where(c => c.Type == ClaimTypes.Role).FirstOrDefault().Value;
    //                var menu = list.Where(x => x.Role.Equals(role) && x.Url.ToLower().Equals(url)).FirstOrDefault();

    //                if (menu == null)
    //                {
    //                    context.Fail();
    //                    return;
    //                }

    //                return;
    //            }
    //        }
    //        context.Fail();
    //    }
    //}

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAuthorizeFilterAttribute : Attribute, IAuthorizeData
    {
        public string Policy { get; set; }
        public string Roles { get; set; }
        public string AuthenticationSchemes { get; set; }

        public void OnAuthorization(AuthorizationFilterContext context)
        { 
        
        }
    }
}
