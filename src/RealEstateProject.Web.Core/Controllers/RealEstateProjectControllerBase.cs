using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RealEstateProject.Controllers
{
    public abstract class RealEstateProjectControllerBase: AbpController
    {
        protected RealEstateProjectControllerBase()
        {
            LocalizationSourceName = RealEstateProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
