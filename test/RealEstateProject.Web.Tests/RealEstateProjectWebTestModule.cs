using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RealEstateProject.EntityFrameworkCore;
using RealEstateProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace RealEstateProject.Web.Tests
{
    [DependsOn(
        typeof(RealEstateProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class RealEstateProjectWebTestModule : AbpModule
    {
        public RealEstateProjectWebTestModule(RealEstateProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RealEstateProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(RealEstateProjectWebMvcModule).Assembly);
        }
    }
}