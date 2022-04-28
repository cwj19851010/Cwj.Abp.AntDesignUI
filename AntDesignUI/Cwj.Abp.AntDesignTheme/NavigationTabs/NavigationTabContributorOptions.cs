using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public class NavigationTabContributorOptions
    {
        public List<INavigationTabContributor> NavigationTabContributors { get; }
        
        public NavigationTabContributorOptions()
        {
            NavigationTabContributors = new List<INavigationTabContributor>();
        }
    }
}
