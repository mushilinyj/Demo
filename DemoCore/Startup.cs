using Autofac;
using DemoCore.AutoModule;
using DemoCore.CookieHelper;
using DemoCore.IServiceHelper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using RedisService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(option =>
            {
              option.AddPolicy("CorsPolicy",
              builder => builder.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader());
            });
            services.AddControllers().AddControllersAsServices();
            //services.AddRedisService(Configuration);
            services.AddSwaggerGen();
            services.AddControllers();

            //services.AddAuthentication("user_token").AddCookie("user_token",options => {
            //    //滑动过期
            //    options.SlidingExpiration = true;
            //    //滑动过期时间30分钟，即30分钟内没有访问页面就过期
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
            //    //无权限访问时跳转到的页面，Pages目录下要有NotAuthor.cshtml页面
            //    options.AccessDeniedPath = "/NotAuthor";
            //});//增加权限认证服务
            //services.AddAuthorization(builder => {
            //    builder.AddPolicy("MyPolicy", sb =>
            //    {
            //        sb.RequireClaim("special", "allow");
            //    });
            //});//接口授权服务

            //jwt接管权限验证
            var jwt = Configuration.GetSection("Jwt").Get<JwtManagement>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
               .AddJwtBearer(options =>
               {
                   options.RequireHttpsMetadata = true;
                   options.SaveToken = true;
                   options.TokenValidationParameters = new TokenValidationParameters
                   {
                       ValidateIssuer = false,
                       ValidateAudience = false,
                       ValidateLifetime = true,
                       ValidateIssuerSigningKey = true,
                       ValidIssuer = jwt.Issuer,
                       ValidAudience = jwt.Audience,
                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Secret))
                   };
               });
            //services.AddAuthentication("cookie")
            //    .AddCookie("cookie")
            //    .AddOAuth("custom", o =>
            //    {
            //        o.SignInScheme = "cookie";
            //        o.ClientId = "shilinmu";
            //        o.ClientSecret = "123456";

            //        o.AuthorizationEndpoint = "https://localhost:44326/oauth/authorize";//授权地址--由于在授权时请求获取code 第三方服务器可设置
            //        o.TokenEndpoint = "https://localhost:44326/oauth/token";//获取token的地址
            //        o.CallbackPath = "/oauth/callback";//回调地址 不会返回真实的html，而是会直接请求服务端地址

            //        //可以理解为更加安全的模式
            //        //会在请求code的时候增加两个参数： code-challenge和code-challenge-method
            //        //请求token的时候会增加一个 code-verfier
            //        //code-verfier = 一个随机的字符串 + base64 即将随机字符串转base64
            //        //code-challenge = 字符串 + sha256哈希 + base64
            //        o.UsePkce = true;
            //        //当我们拿到token的时候会触发这个方法
            //        o.Events.OnCreatingTicket = ctx =>
            //        {
            //            return Task.CompletedTask;
            //        };
            //    });

            services.AddAuthorization();

            // 注册为单例
            services.AddHttpContextAccessor();
            // 注册Cookie操作接口
            services.AddSingleton<ICookieHelper, CookieHelper.CookieHelper>();
            //注入带参服务
            services.AddSingleton<IAuthenticateService>(x => new AuthenticateService(jwt));
          
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            //redis缓存
            var section = Configuration.GetSection("Redis:Default");
            //连接字符串
            string _connectionString = section.GetSection("Connection").Value;
            //实例名称
            string _instanceName = section.GetSection("InstanceName").Value;
            //默认数据库 
            int _defaultDB = int.Parse(section.GetSection("DefaultDB").Value ?? "0");
           
            //RedisHelper.Instance.Init(_connectionString, _instanceName, _defaultDB);
            builder.RegisterModule(new AutofacModule());
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });
            app.UseRouting();
            
            app.UseAuthentication();//权限认证服务
            app.UseAuthorization();//接口授权服务
            app.UseCors("CorsPolicy");
            //app.UseCookiePolicy();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
           
        }
    }
}
