using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public class NavigationTabItem
    {
        public string Url { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }

        public bool CanClose { get; set; }
    }
}
