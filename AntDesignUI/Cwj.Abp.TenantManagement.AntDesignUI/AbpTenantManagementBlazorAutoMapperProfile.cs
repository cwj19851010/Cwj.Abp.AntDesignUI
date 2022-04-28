using AutoMapper;
using Volo.Abp.TenantManagement;

namespace Cwj.Abp.TenantManagement.AntDesignUI;

public class AbpTenantManagementBlazorAutoMapperProfile : Profile
{
    public AbpTenantManagementBlazorAutoMapperProfile()
    {
        CreateMap<TenantDto, TenantUpdateDto>()
            .MapExtraProperties();
    }
}
