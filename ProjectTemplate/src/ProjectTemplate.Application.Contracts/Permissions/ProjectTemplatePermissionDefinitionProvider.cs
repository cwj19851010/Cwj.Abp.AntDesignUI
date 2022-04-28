using ProjectTemplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProjectTemplate.Permissions;

public class ProjectTemplatePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProjectTemplatePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProjectTemplatePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProjectTemplateResource>(name);
    }
}
