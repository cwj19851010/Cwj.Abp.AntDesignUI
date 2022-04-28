using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.PageToolbars;

public interface IPageToolbarManager
{
    Task<PageToolbarItem[]> GetItemsAsync(PageToolbar toolbar);
}
