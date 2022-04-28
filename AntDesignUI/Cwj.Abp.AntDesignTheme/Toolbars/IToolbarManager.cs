using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.Toolbars;

public interface IToolbarManager
{
    Task<Toolbar> GetAsync(string name);
}
