using Rel.Pract.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Rel.Pract.Permissions;

public class PractPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PractPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PractPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PractResource>(name);
    }
}
