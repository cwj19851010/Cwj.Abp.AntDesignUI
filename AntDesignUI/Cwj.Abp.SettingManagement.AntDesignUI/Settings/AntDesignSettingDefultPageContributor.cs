﻿using System.Threading.Tasks;
using Cwj.Abp.SettingManagement.AntDesignUI.Pages.SettingManagement.AntDesignThemeGroup;
using Cwj.Abp.SettingManagement.AntDesignUI.Pages.SettingManagement.EmailSettingGroup;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Volo.Abp.Features;
using Volo.Abp.MultiTenancy;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Localization;

namespace Cwj.Abp.SettingManagement.AntDesignUI.Settings;

public class AntDesignSettingDefultPageContributor : ISettingComponentContributor
{
    public async Task ConfigureAsync(SettingComponentCreationContext context)
    {
        if (!await CheckPermissionsInternalAsync(context))
        {
            return;
        }

        var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<AbpSettingManagementResource>>();
        context.Groups.Add(
            new SettingComponentGroup(
                "Volo.Abp.SettingManagement",
                l["Menu:Emailing"],
                typeof(EmailSettingGroupViewComponent)
            )
        );
        
        //context.Groups.Add(
        //    new SettingComponentGroup(
        //        AntDesignThemeGroupViewComponent.Name,
        //        "Theme",
        //        typeof(AntDesignThemeGroupViewComponent)
        //    )
        //);
    }

    public async Task<bool> CheckPermissionsAsync(SettingComponentCreationContext context)
    {
        return await CheckPermissionsInternalAsync(context);
    }

    private async Task<bool> CheckPermissionsInternalAsync(SettingComponentCreationContext context)
    {
        if (!await CheckFeatureAsync(context))
        {
            return false;
        }

        var authorizationService = context.ServiceProvider.GetRequiredService<IAuthorizationService>();

        return await authorizationService.IsGrantedAsync(SettingManagementPermissions.Emailing);
    }

    private async Task<bool> CheckFeatureAsync(SettingComponentCreationContext context)
    {
        var currentTenant = context.ServiceProvider.GetRequiredService<ICurrentTenant>();

        if (!currentTenant.IsAvailable)
        {
            return true;
        }

        var featureCheck = context.ServiceProvider.GetRequiredService<IFeatureChecker>();

        return await featureCheck.IsEnabledAsync(SettingManagementFeatures.AllowTenantsToChangeEmailSettings);

    }
}
