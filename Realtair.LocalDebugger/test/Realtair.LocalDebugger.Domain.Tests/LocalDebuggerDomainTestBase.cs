using Volo.Abp.Modularity;

namespace Realtair.LocalDebugger;

/* Inherit from this class for your domain layer tests. */
public abstract class LocalDebuggerDomainTestBase<TStartupModule> : LocalDebuggerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
