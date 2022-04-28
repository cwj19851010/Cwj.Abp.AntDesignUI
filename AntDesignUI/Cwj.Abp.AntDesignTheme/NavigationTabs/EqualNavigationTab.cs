using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public class EqualNavigationTab : NavigationTab
    {

        public override bool IsCurrentRouter(string url)
        {
            return url.Equals(RouterUrl);        
        }
    }
}
