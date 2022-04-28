using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public interface INavigationTabContributor
    {
        List<INavigationTab> ConfigureNavigationTab(INavigationTabConfigurationContext context);
    }
}
