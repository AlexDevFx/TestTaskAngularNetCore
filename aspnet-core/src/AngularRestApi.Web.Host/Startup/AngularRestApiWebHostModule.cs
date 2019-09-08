using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AngularRestApi.Configuration;

namespace AngularRestApi.Web.Host.Startup
{
    [DependsOn(
       typeof(AngularRestApiWebCoreModule))]
    public class AngularRestApiWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AngularRestApiWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AngularRestApiWebHostModule).GetAssembly());
        }
    }
}
