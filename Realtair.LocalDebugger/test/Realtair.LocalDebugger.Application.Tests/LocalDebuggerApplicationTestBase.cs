using Volo.Abp.Modularity;

namespace Realtair.LocalDebugger;

public abstract class LocalDebuggerApplicationTestBase<TStartupModule> : LocalDebuggerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
