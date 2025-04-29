using Realtair.LocalDebugger.Localization;
using Volo.Abp.Application.Services;

namespace Realtair.LocalDebugger;

/* Inherit your application services from this class.
 */
public abstract class LocalDebuggerAppService : ApplicationService
{
    protected LocalDebuggerAppService()
    {
        LocalizationResource = typeof(LocalDebuggerResource);
    }
}
