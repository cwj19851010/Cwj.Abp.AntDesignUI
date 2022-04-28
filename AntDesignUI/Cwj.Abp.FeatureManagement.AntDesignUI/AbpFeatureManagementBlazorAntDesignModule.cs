using Cwj.Abp.AntDesignTheme;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Features;
using Volo.Abp.Modularity;

namespace Cwj.Abp.FeatureManagement.AntDesignUI;

[DependsOn(
    typeof(AbpAntDesignThemeModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpFeaturesModule),
    typeof(AbpFeatureManagementHttpApiClientModule)
)]
public class AbpFeatureManagementBlazorAntDesignModule : AbpModule
{

}
