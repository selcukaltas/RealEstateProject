using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RealEstateProject.Authorization;

namespace RealEstateProject
{
    [DependsOn(
        typeof(RealEstateProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RealEstateProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RealEstateProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RealEstateProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
