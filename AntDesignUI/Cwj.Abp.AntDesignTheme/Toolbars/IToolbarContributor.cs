using System.Threading.Tasks;

namespace Cwj.Abp.AntDesignTheme.Toolbars;

public interface IToolbarContributor
{
    Task ConfigureToolbarAsync(IToolbarConfigurationContext context);
}
