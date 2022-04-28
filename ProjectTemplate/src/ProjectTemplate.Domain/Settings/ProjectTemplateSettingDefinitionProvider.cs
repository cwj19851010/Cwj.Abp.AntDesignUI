using Volo.Abp.Settings;

namespace ProjectTemplate.Settings;

public class ProjectTemplateSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProjectTemplateSettings.MySetting1));
    }
}
