﻿using AutoMapper;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;

namespace Cwj.Abp.IdentityManagement.AntDesignUI;

public class AbpIdentityBlazorAntDesignAutoMapperProfile: Profile
{
    public AbpIdentityBlazorAntDesignAutoMapperProfile()
    {
        CreateMap<IdentityUserDto, IdentityUserUpdateDto>()
            .MapExtraProperties()
            .Ignore(x => x.Password)
            .Ignore(x => x.RoleNames);

        CreateMap<IdentityRoleDto, IdentityRoleUpdateDto>()
            .MapExtraProperties();
    }
}
