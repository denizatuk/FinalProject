using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.IoC
{
    public interface ICoreModule
    {
        public class CoreModule : ICoreModule
        {
            public void Load(IServiceCollection services)
            {
                services.AddMemoryCache();
               
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            }
        }
    }
}
