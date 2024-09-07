using ProducrManagmentAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ProducrManagmentAPI.Permissions;

public class ProducrManagmentAPIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProducrManagmentAPIPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ProducrManagmentAPIPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProducrManagmentAPIResource>(name);
    }
}
