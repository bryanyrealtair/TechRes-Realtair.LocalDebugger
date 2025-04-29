using Volo.Abp.Modularity;

namespace Realtair.LocalDebugger;

[DependsOn(
    typeof(LocalDebuggerApplicationModule),
    typeof(LocalDebuggerDomainTestModule)
)]
public class LocalDebuggerApplicationTestModule : AbpModule
{

}
