using Realtair.LocalDebugger.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Realtair.LocalDebugger.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LocalDebuggerEntityFrameworkCoreModule),
    typeof(LocalDebuggerApplicationContractsModule)
)]
public class LocalDebuggerDbMigratorModule : AbpModule
{
}
