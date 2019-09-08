using System.Threading.Tasks;
using Abp.Application.Services;
using AngularRestApi.Sessions.Dto;

namespace AngularRestApi.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
