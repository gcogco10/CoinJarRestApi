
using CoinJarRestAPI.Dependency_Injection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoinJarRestAPI
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddSingleton<CoinJar>(provider => new CoinJar());
        }
    }
}