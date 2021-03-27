using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RealEstateProject.Configuration;

namespace RealEstateProject.Web.Host.Startup
{
    [DependsOn(
       typeof(RealEstateProjectWebCoreModule))]
    public class RealEstateProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RealEstateProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RealEstateProjectWebHostModule).GetAssembly());
        }
    }
}
