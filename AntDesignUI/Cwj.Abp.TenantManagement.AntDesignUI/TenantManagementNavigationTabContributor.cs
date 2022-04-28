using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesign;
using Cwj.Abp.AntDesignTheme.NavigationTabs;
using Cwj.Abp.AntDesignTheme.Toolbars;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.TenantManagement.Localization;
using Volo.Abp.UI.Navigation;

namespace Cwj.Abp.TenantManagement.AntDesignUI;

public class TenantManagementNavigationTabContributor : INavigationTabContributor
{
    public List<INavigationTab> ConfigureNavigationTab(INavigationTabConfigurationContext context)
    {
        var l = context.GetLocalizer<AbpTenantManagementResource>();
        var list = new List<INavigationTab>();
        var navigationTab = new NavigationTab();
        navigationTab.Title = l["Tenants"];
        navigationTab.Icon = IconType.Outline.Team;
        navigationTab.RouterUrl = "/tenant-management/tenants";
        navigationTab.DefaultUrl = "/tenant-management/tenants";
        navigationTab.CanClose = true;
        list.Add(navigationTab);
        return list;
    }
}
