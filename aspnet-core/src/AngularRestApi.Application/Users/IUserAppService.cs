using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AngularRestApi.Roles.Dto;
using AngularRestApi.Users.Dto;

namespace AngularRestApi.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
