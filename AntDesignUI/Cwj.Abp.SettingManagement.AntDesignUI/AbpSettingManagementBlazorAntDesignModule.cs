using AutoMapper;
using Cwj.Abp.AntDesignTheme;
using Cwj.Abp.AntDesignTheme.NavigationTabs;
using Cwj.Abp.AntDesignTheme.Routing;
using Cwj.Abp.SettingManagement.AntDesignUI.Settings;
using Cwj.Abp.TenantManagement.AntDesignUI;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.SettingManagement;
using Volo.Abp.UI.Navigation;

namespace Cwj.Abp.SettingManagement.AntDesignUI;

[DependsOn(
    typeof(AbpAutoMapperModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpAntDesignThemeModule),
    typeof(AbpSettingManagementHttpApiClientModule)
)]
public class AbpSettingManagementBlazorAntDesignModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AbpSettingManagementBlazorAntDesignModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<SettingManagementBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new SettingManagementMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AbpSettingManagementBlazorAntDesignModule).Assembly);
        });

        Configure<SettingManagementComponentOptions>(options =>
        {
            options.Contributors.Add(new AntDesignSettingDefultPageContributor());
        });

        Configure<NavigationTabContributorOptions>(options =>
        {
            options.NavigationTabContributors.Add(new SettingManagementNavigationTabContributor());
        });
    }
}
