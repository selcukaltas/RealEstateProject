using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using RealEstateProject.Controllers;

namespace RealEstateProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : RealEstateProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
