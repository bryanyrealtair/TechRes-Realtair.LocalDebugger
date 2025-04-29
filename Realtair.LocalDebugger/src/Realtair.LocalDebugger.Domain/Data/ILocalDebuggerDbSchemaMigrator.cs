using System.Threading.Tasks;

namespace Realtair.LocalDebugger.Data;

public interface ILocalDebuggerDbSchemaMigrator
{
    Task MigrateAsync();
}
