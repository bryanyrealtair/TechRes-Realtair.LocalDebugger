using Realtair.LocalDebugger.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Realtair.LocalDebugger.Web.Pages;

public abstract class LocalDebuggerPageModel : AbpPageModel
{
    protected LocalDebuggerPageModel()
    {
        LocalizationResourceType = typeof(LocalDebuggerResource);
    }
}
