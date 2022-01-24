using Abp.Authorization;
using ClubTest.Authorization.Roles;
using ClubTest.Authorization.Users;

namespace ClubTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
