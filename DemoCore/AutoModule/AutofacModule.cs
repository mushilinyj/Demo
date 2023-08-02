using Autofac;
using Autofac.Core;
using DemoCore.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Reflection;

namespace DemoCore.AutoModule
{
    public class AutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // 获取所有控制器类型并使用属性注入
            var controllerBaseType = typeof(BaseController);
            builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                .Where(t => controllerBaseType.IsAssignableFrom(t) && t != controllerBaseType)
                .PropertiesAutowired(new AutowiredPropertySelector());
        }
        /// <summary>
        /// 属性注入选择器
        /// </summary>
        public class AutowiredPropertySelector : IPropertySelector
        {
            public bool InjectProperty(PropertyInfo propertyInfo, object instance)
            {
                // 带有 AutowiredAttribute 特性的属性会进行属性注入
                return propertyInfo.CustomAttributes.Any(it => it.AttributeType == typeof(AutowiredAttribute));
            }
        }
    }
}
