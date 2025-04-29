using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Realtair.LocalDebugger.Data;

/* This is used if database provider does't define
 * ILocalDebuggerDbSchemaMigrator implementation.
 */
public class NullLocalDebuggerDbSchemaMigrator : ILocalDebuggerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
