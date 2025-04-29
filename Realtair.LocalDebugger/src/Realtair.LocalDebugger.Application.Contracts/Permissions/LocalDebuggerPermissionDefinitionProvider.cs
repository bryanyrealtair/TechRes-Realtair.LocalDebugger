using Realtair.LocalDebugger.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Realtair.LocalDebugger.Permissions;

public class LocalDebuggerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LocalDebuggerPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(LocalDebuggerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LocalDebuggerResource>(name);
    }
}
