using Cwj.Abp.AntDesignUI;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Cwj.Abp.PermissionManagement.AntDesignUI;

[DependsOn(
    typeof(AbpAntDesignUIModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpPermissionManagementApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiClientModule)
)]
public class AbpPermissionManagementAntDesignModule : AbpModule
{

}
