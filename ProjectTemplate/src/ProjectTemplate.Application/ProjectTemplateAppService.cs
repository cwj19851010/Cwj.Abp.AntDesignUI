using System;
using System.Collections.Generic;
using System.Text;
using ProjectTemplate.Localization;
using Volo.Abp.Application.Services;

namespace ProjectTemplate;

/* Inherit your application services from this class.
 */
public abstract class ProjectTemplateAppService : ApplicationService
{
    protected ProjectTemplateAppService()
    {
        LocalizationResource = typeof(ProjectTemplateResource);
    }
}
