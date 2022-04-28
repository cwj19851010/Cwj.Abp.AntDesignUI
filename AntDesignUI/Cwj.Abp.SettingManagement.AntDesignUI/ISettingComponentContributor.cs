using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.SettingManagement;

public interface ISettingComponentContributor
{
    Task ConfigureAsync(SettingComponentCreationContext context);

    Task<bool> CheckPermissionsAsync(SettingComponentCreationContext context);
}
