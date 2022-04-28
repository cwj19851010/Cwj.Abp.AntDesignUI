using AutoMapper;
using Volo.Abp.SettingManagement;

namespace Cwj.Abp.SettingManagement.AntDesignUI;

public class SettingManagementBlazorAutoMapperProfile : Profile
{
    public SettingManagementBlazorAutoMapperProfile()
    {
        CreateMap<EmailSettingsDto, UpdateEmailSettingsDto>();
    }
}
