using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ClubTest.Controllers
{
    public abstract class ClubTestControllerBase: AbpController
    {
        protected ClubTestControllerBase()
        {
            LocalizationSourceName = ClubTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
