using System.Threading.Tasks;
using AngularRestApi.Configuration.Dto;

namespace AngularRestApi.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
