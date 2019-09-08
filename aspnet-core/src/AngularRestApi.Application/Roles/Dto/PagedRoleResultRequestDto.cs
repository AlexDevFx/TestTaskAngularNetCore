using Abp.Application.Services.Dto;

namespace AngularRestApi.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

