using System.Threading.Tasks;
using Cwj.Abp.AntDesignTheme.PageToolbars;

namespace Cwj.Abp.AntDesignTheme.PageToolbars;

public interface IPageToolbarContributor
{
    Task ContributeAsync(PageToolbarContributionContext context);
}
