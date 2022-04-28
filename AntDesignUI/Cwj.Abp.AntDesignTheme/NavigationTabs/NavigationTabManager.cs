using Cwj.Abp.AntDesignTheme.PageToolbars;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Cwj.Abp.AntDesignTheme.NavigationTabs
{
    public class NavigationTabManager : INavigationTabManager, ITransientDependency
    {
        private readonly IOptions<NavigationTabContributorOptions> _options;
        private readonly IServiceProvider _serviceProvider;
        public NavigationTabManager(IOptions<NavigationTabContributorOptions> options, IServiceProvider serviceProvider)
        {
            _options = options;
            _serviceProvider = serviceProvider;
        }
        public List<INavigationTab> GetItems()
        {
            var list = new List<INavigationTab>();
            foreach (var item in _options.Value.NavigationTabContributors)
            {
                var itemList = item.ConfigureNavigationTab(new NavigationTabConfigurationContext(_serviceProvider));
                list.AddRange(itemList);
            }
            return list;
        }
    }
}
