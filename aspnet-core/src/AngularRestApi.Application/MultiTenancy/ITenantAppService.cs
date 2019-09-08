using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AngularRestApi.MultiTenancy.Dto;

namespace AngularRestApi.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

