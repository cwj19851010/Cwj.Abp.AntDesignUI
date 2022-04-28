using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesign;
using Cwj.Abp.AntDesignTheme.NavigationTabs;
using Cwj.Abp.AntDesignTheme.Toolbars;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.SettingManagement.Localization;
using Volo.Abp.UI.Navigation;

namespace Cwj.Abp.TenantManagement.AntDesignUI;

public class SettingManagementNavigationTabContributor : INavigationTabContributor
{
    public List<INavigationTab> ConfigureNavigationTab(INavigationTabConfigurationContext context)
    {
        var l = context.GetLocalizer<AbpSettingManagementResource>();
        var list = new List<INavigationTab>();
        var navigationTab = new NavigationTab();
        navigationTab.Title = l["Settings"];
        navigationTab.Icon = IconType.Outline.Setting;
        navigationTab.RouterUrl = "/setting-management";
        navigationTab.DefaultUrl = "/setting-management";
        navigationTab.CanClose = true;
        list.Add(navigationTab);
        return list;
    }
}
