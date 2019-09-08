using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularRestApi.Authorization;

namespace AngularRestApi
{
    [DependsOn(
        typeof(AngularRestApiCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AngularRestApiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AngularRestApiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AngularRestApiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
