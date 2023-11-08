using Core.CrossCuttingConcerns.Cashing;
using Core.CrossCuttingConcerns.Cashing.Microsoft;
using Core.Utilities.Ioc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.DependencyResolves
{
    public class CoreModule : ICoreModule
    {
        public void Load(ServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache(); // IMemoryCache _memoryCache karşılığı arkaplanda hazır bir instance oluşturur
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();//PerformanceAspect.cs

        }
    }
}
