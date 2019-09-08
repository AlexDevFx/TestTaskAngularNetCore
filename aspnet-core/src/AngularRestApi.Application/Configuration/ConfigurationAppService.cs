using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AngularRestApi.Configuration.Dto;

namespace AngularRestApi.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AngularRestApiAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
