using DemoCore.AuthorizationHelper;
using Microsoft.AspNetCore.Builder;

namespace DemoCore.IServiceHelper
{
    public static class OptionsRequstMiddlewareExtensions
    {
        /// <summary>
        /// 解决 axios 跨域请求时的OPTIONS（预检请求）请求无法通过鉴权而导致前端post/get/delete等请求失败情况
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseOptionsRequst(this IApplicationBuilder app)
        {
            return app.UseMiddleware<OptionsRequestMiddleware>();//UseMiddleware配置中间件
        }
    }
}
