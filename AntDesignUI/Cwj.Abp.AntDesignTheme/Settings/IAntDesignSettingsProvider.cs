using System;
using System.Threading.Tasks;
using AntDesign;

namespace Cwj.Abp.AntDesignTheme.Settings;

public interface IAntDesignSettingsProvider
{
    Task<MenuPlacement> GetMenuPlacementAsync();

    Task<MenuTheme> GetMenuThemeAsync();

    Task TriggerSettingChanged();
    
    public event AntDesignSettingsProvider.AntDesignSettingChangedHandler SettingChanged;
}
