using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProjectTemplate.Data;

/* This is used if database provider does't define
 * IProjectTemplateDbSchemaMigrator implementation.
 */
public class NullProjectTemplateDbSchemaMigrator : IProjectTemplateDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
