using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ClubTest.EntityFrameworkCore;
using ClubTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ClubTest.Web.Tests
{
    [DependsOn(
        typeof(ClubTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ClubTestWebTestModule : AbpModule
    {
        public ClubTestWebTestModule(ClubTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ClubTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ClubTestWebMvcModule).Assembly);
        }
    }
}