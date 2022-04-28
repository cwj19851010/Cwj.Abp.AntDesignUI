using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public interface INavigationTab
    {
        string Title { get; set; }

        string DefaultUrl { get; set; }

        string Icon { get; set; }

        bool CanClose { get; set; }
        bool IsFirst { get; set; }
        string RouterUrl { get; set; }

        bool IsCurrentRouter(string url);
    }
}
