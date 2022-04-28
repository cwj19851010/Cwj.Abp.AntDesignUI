using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesign;
using Cwj.Abp.AntDesignTheme.NavigationTabs;
using Cwj.Abp.AntDesignTheme.Toolbars;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Localization;
using Volo.Abp.UI.Navigation;

namespace Cwj.Abp.IdentityManagement.AntDesignUI;

public class AbpIdentityNavigationTabContributor : INavigationTabContributor
{
    public List<INavigationTab> ConfigureNavigationTab(INavigationTabConfigurationContext context)
    {
        var l = context.GetLocalizer<IdentityResource>();
        var list = new List<INavigationTab>();
        var navigationTab = new NavigationTab();
        navigationTab.CanClose = true;
        navigationTab.Title = l["Roles"];
        navigationTab.Icon = IconType.Outline.User;
        navigationTab.RouterUrl = "/identity/roles";
        navigationTab.DefaultUrl = "/identity/roles";
        list.Add(navigationTab);
        navigationTab = new NavigationTab();
        navigationTab.CanClose = true;
        navigationTab.Title = l["Users"];
        navigationTab.Icon = IconType.Outline.User;
        navigationTab.RouterUrl = "/identity/users";
        navigationTab.DefaultUrl = "/identity/users";
        list.Add(navigationTab);
        return list;
    }
}
