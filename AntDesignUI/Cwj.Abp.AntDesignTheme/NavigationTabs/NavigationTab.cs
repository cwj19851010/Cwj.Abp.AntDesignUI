using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public class NavigationTab : INavigationTab
    {
        public string Title { get; set; }
        public string DefaultUrl { get; set; }
        public string Icon { get; set; }
        public bool CanClose { get; set; }
        public string RouterUrl { get; set; }
        public bool IsFirst { get; set; }

        public virtual bool IsCurrentRouter(string url)
        {
            return url.StartsWith(RouterUrl);        }
    }
}
