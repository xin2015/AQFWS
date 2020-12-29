using AQFWS.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AQFWS.Permissions
{
    public class AQFWSPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AQFWSPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AQFWSPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AQFWSResource>(name);
        }
    }
}
