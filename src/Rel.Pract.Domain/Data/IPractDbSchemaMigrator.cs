using System.Threading.Tasks;

namespace Rel.Pract.Data;

public interface IPractDbSchemaMigrator
{
    Task MigrateAsync();
}
