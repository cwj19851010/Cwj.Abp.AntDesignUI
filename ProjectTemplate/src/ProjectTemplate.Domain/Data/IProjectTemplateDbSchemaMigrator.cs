using System.Threading.Tasks;

namespace ProjectTemplate.Data;

public interface IProjectTemplateDbSchemaMigrator
{
    Task MigrateAsync();
}
