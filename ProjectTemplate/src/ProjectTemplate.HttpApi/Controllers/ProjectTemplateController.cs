using ProjectTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProjectTemplate.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProjectTemplateController : AbpControllerBase
{
    protected ProjectTemplateController()
    {
        LocalizationResource = typeof(ProjectTemplateResource);
    }
}
