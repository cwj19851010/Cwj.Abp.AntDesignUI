using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectTemplate.Data;
using Volo.Abp.DependencyInjection;

namespace ProjectTemplate.EntityFrameworkCore;

public class EntityFrameworkCoreProjectTemplateDbSchemaMigrator
    : IProjectTemplateDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProjectTemplateDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ProjectTemplateDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProjectTemplateDbContext>()
            .Database
            .MigrateAsync();
    }
}
