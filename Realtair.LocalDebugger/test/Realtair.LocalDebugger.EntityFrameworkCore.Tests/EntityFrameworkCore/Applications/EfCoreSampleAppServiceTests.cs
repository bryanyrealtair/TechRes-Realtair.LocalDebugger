using Realtair.LocalDebugger.Samples;
using Xunit;

namespace Realtair.LocalDebugger.EntityFrameworkCore.Applications;

[Collection(LocalDebuggerTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<LocalDebuggerEntityFrameworkCoreTestModule>
{

}
