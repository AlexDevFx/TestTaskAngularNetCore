using Abp.Authorization;
using AngularRestApi.Authorization.Roles;
using AngularRestApi.Authorization.Users;

namespace AngularRestApi.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
