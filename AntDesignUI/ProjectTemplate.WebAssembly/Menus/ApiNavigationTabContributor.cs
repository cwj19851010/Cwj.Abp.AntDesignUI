
using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesign;
using Cwj.Abp.AntDesignTheme.NavigationTabs;
using Cwj.Abp.AntDesignTheme.Toolbars;
using ProjectTemplate.Localization;
using Volo.Abp.Account.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Localization;
using Volo.Abp.UI.Navigation;

namespace Cwj.Abp.IdentityManagement.AntDesignUI;

public class ApiNavigationTabContributor : INavigationTabContributor
{
    public List<INavigationTab> ConfigureNavigationTab(INavigationTabConfigurationContext context)
    {
        var l = context.GetLocalizer<ProjectTemplateResource>();
        var list = new List<INavigationTab>();
        NavigationTab navigationTab = new EqualNavigationTab();
        navigationTab.Title = l["Menu:Home"];
        navigationTab.Icon = "home";
        navigationTab.RouterUrl = "/";
        navigationTab.DefaultUrl = "/";
        navigationTab.CanClose = false;
        navigationTab.IsFirst = true;
        list.Add(navigationTab);
        l = context.GetLocalizer<AccountResource>();
        navigationTab = new NavigationTab();
        navigationTab.Title = l["MyAccount"];
        navigationTab.Icon = IconType.Outline.User;
        navigationTab.RouterUrl = "/Account/Manage";
        navigationTab.DefaultUrl = "/Account/Manage";
        list.Add(navigationTab);
        return list;
    }
}
