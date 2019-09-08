using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AngularRestApi.Controllers
{
    public abstract class AngularRestApiControllerBase: AbpController
    {
        protected AngularRestApiControllerBase()
        {
            LocalizationSourceName = AngularRestApiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
