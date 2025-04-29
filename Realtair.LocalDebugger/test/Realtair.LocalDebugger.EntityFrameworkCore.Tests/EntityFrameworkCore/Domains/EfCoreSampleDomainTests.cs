using Realtair.LocalDebugger.Samples;
using Xunit;

namespace Realtair.LocalDebugger.EntityFrameworkCore.Domains;

[Collection(LocalDebuggerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<LocalDebuggerEntityFrameworkCoreTestModule>
{

}
