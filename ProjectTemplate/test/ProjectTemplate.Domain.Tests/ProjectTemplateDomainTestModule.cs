using ProjectTemplate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProjectTemplate;

[DependsOn(
    typeof(ProjectTemplateEntityFrameworkCoreTestModule)
    )]
public class ProjectTemplateDomainTestModule : AbpModule
{

}
