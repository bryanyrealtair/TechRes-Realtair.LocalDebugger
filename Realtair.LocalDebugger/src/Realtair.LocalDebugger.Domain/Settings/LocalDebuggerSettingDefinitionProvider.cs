using Volo.Abp.Settings;

namespace Realtair.LocalDebugger.Settings;

public class LocalDebuggerSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LocalDebuggerSettings.MySetting1));
    }
}
