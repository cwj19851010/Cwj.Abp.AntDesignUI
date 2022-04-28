using ProjectTemplate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ProjectTemplate.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProjectTemplateEntityFrameworkCoreModule),
    typeof(ProjectTemplateApplicationContractsModule)
    )]
public class ProjectTemplateDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
