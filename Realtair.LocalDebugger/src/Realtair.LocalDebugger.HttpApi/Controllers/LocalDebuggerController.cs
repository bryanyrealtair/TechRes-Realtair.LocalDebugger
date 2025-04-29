using Realtair.LocalDebugger.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Realtair.LocalDebugger.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LocalDebuggerController : AbpControllerBase
{
    protected LocalDebuggerController()
    {
        LocalizationResource = typeof(LocalDebuggerResource);
    }
}
