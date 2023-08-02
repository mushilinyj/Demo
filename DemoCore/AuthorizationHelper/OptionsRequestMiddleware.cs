using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DemoCore.AuthorizationHelper
{
    public class OptionsRequestMiddleware
    {
        private readonly RequestDelegate _next;
        public OptionsRequestMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method.ToUpper() == "OPTIONS")
            {
                context.Response.Headers.AccessControlAllowHeaders = "access-control-allow-origin,authorization,content-type";
                context.Response.Headers.AccessControlAllowMethods = "POST,GET,DELETE";//表示服务器可以接受所有的请求方法
                context.Response.Headers.AccessControlAllowOrigin = "*";//允许所有服务器请求资源--表示服务器可以接受所有的请求源
                context.Response.StatusCode = 204;
                return;
            }
            await _next.Invoke(context);
        }
    }
}
