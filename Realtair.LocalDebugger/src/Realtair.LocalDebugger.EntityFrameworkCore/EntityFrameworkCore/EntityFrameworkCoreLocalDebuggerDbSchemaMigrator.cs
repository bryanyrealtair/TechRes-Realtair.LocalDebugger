using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Realtair.LocalDebugger.Data;
using Volo.Abp.DependencyInjection;

namespace Realtair.LocalDebugger.EntityFrameworkCore;

public class EntityFrameworkCoreLocalDebuggerDbSchemaMigrator
    : ILocalDebuggerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLocalDebuggerDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LocalDebuggerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LocalDebuggerDbContext>()
            .Database
            .MigrateAsync();
    }
}
