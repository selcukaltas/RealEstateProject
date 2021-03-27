using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace RealEstateProject.Web.Views
{
    public abstract class RealEstateProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected RealEstateProjectRazorPage()
        {
            LocalizationSourceName = RealEstateProjectConsts.LocalizationSourceName;
        }
    }
}
