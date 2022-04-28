using System.Threading.Tasks;
using Cwj.Abp.AntDesignTheme.PageToolbars;

namespace Cwj.Abp.AntDesignTheme.PageToolbars;

public abstract class PageToolbarContributor : IPageToolbarContributor
{
    public abstract Task ContributeAsync(PageToolbarContributionContext context);
}
