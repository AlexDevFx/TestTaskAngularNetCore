using Microsoft.AspNetCore.Antiforgery;
using AngularRestApi.Controllers;

namespace AngularRestApi.Web.Host.Controllers
{
    public class AntiForgeryController : AngularRestApiControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
