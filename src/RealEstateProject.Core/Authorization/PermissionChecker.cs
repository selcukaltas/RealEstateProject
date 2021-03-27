using Abp.Authorization;
using RealEstateProject.Authorization.Roles;
using RealEstateProject.Authorization.Users;

namespace RealEstateProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
