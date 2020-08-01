using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using AddHttpClientSingletonExample.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AddHttpClientSingletonExample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton<ICounterService, CounterService>();
            builder.Services.AddSingleton<IhttpFactory, HttpFactory>();

            builder.Services.Configure<HttpOptions>(options => options.BaseUrl = "http://localhost:5000");

            await builder.Build().RunAsync();
        }
    }
}
