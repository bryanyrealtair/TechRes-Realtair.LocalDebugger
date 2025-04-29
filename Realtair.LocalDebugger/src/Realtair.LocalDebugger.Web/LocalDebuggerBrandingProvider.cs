using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using Realtair.LocalDebugger.Localization;

namespace Realtair.LocalDebugger.Web;

[Dependency(ReplaceServices = true)]
public class LocalDebuggerBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<LocalDebuggerResource> _localizer;

    public LocalDebuggerBrandingProvider(IStringLocalizer<LocalDebuggerResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
