using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClubTest.Authorization;

namespace ClubTest
{
    [DependsOn(
        typeof(ClubTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ClubTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ClubTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ClubTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
