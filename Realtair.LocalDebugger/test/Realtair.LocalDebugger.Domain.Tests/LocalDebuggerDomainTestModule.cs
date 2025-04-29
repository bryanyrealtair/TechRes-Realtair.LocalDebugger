using Volo.Abp.Modularity;

namespace Realtair.LocalDebugger;

[DependsOn(
    typeof(LocalDebuggerDomainModule),
    typeof(LocalDebuggerTestBaseModule)
)]
public class LocalDebuggerDomainTestModule : AbpModule
{

}
