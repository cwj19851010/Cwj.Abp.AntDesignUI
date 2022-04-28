using AntDesign.ProLayout;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SmartCode.Web;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjectTemplate.WebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var application = await builder.AddApplicationAsync<ProjectTemplateWebAssemblyModule>(options =>
            {
                options.UseAutofac();
            });
            var host = builder.Build();
            await application.InitializeApplicationAsync(host.Services);
            await host.RunAsync();
        }
    }
}