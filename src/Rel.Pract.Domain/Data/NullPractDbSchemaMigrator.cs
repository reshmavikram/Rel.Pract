using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Rel.Pract.Data;

/* This is used if database provider does't define
 * IPractDbSchemaMigrator implementation.
 */
public class NullPractDbSchemaMigrator : IPractDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
