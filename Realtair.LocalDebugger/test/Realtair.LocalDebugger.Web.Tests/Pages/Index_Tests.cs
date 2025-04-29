using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Realtair.LocalDebugger.Pages;

[Collection(LocalDebuggerTestConsts.CollectionDefinitionName)]
public class Index_Tests : LocalDebuggerWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
