using Xunit;

namespace Realtair.LocalDebugger.EntityFrameworkCore;

[CollectionDefinition(LocalDebuggerTestConsts.CollectionDefinitionName)]
public class LocalDebuggerEntityFrameworkCoreCollection : ICollectionFixture<LocalDebuggerEntityFrameworkCoreFixture>
{

}
