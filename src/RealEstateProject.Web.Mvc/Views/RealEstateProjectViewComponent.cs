using Abp.AspNetCore.Mvc.ViewComponents;

namespace RealEstateProject.Web.Views
{
    public abstract class RealEstateProjectViewComponent : AbpViewComponent
    {
        protected RealEstateProjectViewComponent()
        {
            LocalizationSourceName = RealEstateProjectConsts.LocalizationSourceName;
        }
    }
}
