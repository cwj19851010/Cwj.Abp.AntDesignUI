using Volo.Abp.Modularity;

namespace ProjectTemplate;

[DependsOn(
    typeof(ProjectTemplateApplicationModule),
    typeof(ProjectTemplateDomainTestModule)
    )]
public class ProjectTemplateApplicationTestModule : AbpModule
{

}
