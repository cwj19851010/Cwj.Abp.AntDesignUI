using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public class NavigationTabOptions
    {
        public List<INavigationTab> NavigationTabs { get;}

        public NavigationTabOptions()
        {
            NavigationTabs = new List<INavigationTab>();
        }
    }
}
