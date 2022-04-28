using AntDesign.ProLayout;
using Cwj.Abp.AntDesignTheme.NavigationTabs;
using Cwj.Abp.AntDesignTheme.Routing;
using Cwj.Abp.IdentityManagement.AntDesignUI;
using Cwj.Abp.SettingManagement.AntDesignUI;
using Cwj.Abp.TenantManagement.AntDesignUI;
using IdentityModel;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectTemplate.WebAssembly;
using ProjectTemplate.WebAssembly.Menus;
using System;
using System.Net.Http;
using Volo.Abp.Autofac.WebAssembly;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;
using Volo.Abp.UI.Navigation;

namespace SmartCode.Web
{
    [DependsOn(
        typeof(AbpAutofacWebAssemblyModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpIdentityBlazorAntDesignModule),
        typeof(AbpTenantManagementBlazorAntDesignModule),
        typeof(AbpSettingManagementBlazorAntDesignModule)
)]
    public class ProjectTemplateWebAssemblyModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var environment = context.Services.GetSingletonInstance<IWebAssemblyHostEnvironment>();
            var builder = context.Services.GetSingletonInstance<WebAssemblyHostBuilder>();

            builder.Services.Configure<ProSettings>(builder.Configuration.GetSection("ProSettings"));
            ConfigureUI(builder);
            ConfigureAuthentication(builder);
            ConfigureHttpClient(context, environment);
            ConfigureRouter(context);
            ConfigureMenu(context);
            ConfigureAutoMapper(context);
        }

        private void ConfigureMenu(ServiceConfigurationContext context)
        {
            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new ApiMenuContributor(context.Services.GetConfiguration()));
            });
            Configure<NavigationTabContributorOptions>(options =>
            {
                options.NavigationTabContributors.Add(new ApiNavigationTabContributor());
            });
        }

        private void ConfigureRouter(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AppAssembly = typeof(ProjectTemplateWebAssemblyModule).Assembly;
            });
        }

        public static void ConfigureAuthentication(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("AuthServer", options.ProviderOptions);
                options.UserOptions.RoleClaim = JwtClaimTypes.Role;
                options.ProviderOptions.DefaultScopes.Add("ProjectTemplate");
                options.ProviderOptions.DefaultScopes.Add("role");
                options.ProviderOptions.DefaultScopes.Add("email");
                options.ProviderOptions.DefaultScopes.Add("phone");
            });
        }



        private static void ConfigureHttpClient(ServiceConfigurationContext context,
            IWebAssemblyHostEnvironment environment)
        {
            context.Services.AddTransient(sp => new HttpClient
            {
                BaseAddress = new Uri(environment.BaseAddress),
                Timeout = TimeSpan.FromSeconds(600),
            });
        }

        private void ConfigureAutoMapper(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options => { });
        }
        private static void ConfigureUI(WebAssemblyHostBuilder builder)
        {
            builder.RootComponents.Add<App>("#app");
        }

    }
}
