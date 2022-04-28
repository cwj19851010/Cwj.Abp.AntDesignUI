using Cwj.Abp.AntDesignTheme.NavigationTabs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.PageToolbars;

public interface INavigationTabManager
{
    List<INavigationTab> GetItems();
}
