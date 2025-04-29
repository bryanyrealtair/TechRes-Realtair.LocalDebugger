using Microsoft.AspNetCore.Builder;
using Realtair.LocalDebugger;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Realtair.LocalDebugger.Web.csproj"); 
await builder.RunAbpModuleAsync<LocalDebuggerWebTestModule>(applicationName: "Realtair.LocalDebugger.Web");

public partial class Program
{
}
