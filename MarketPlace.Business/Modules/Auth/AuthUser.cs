using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Auth
{
    public class AuthUser : IAuthUser
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly IUrlHelper _urlHelper;

        public AuthUser(IHttpContextAccessor accessor, IUrlHelper urlHelper)
        {
            _accessor = accessor;
            _urlHelper = urlHelper;
        }

        public string Name => _accessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;


        public string EmailAddress => _accessor.HttpContext?.User?.FindFirst(ClaimTypes.Email)?.Value;
        public bool Authenticated => _accessor.HttpContext.User.Identity.IsAuthenticated;

        public string UserId => _accessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        public string IPAddress => _accessor.HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        public string UserCategory => _accessor.HttpContext.User.FindFirst("UserCategory")?.Value;
        public string HostBaseUrl => $"{_urlHelper.ActionContext.HttpContext.Request.Scheme}://{_urlHelper.ActionContext.HttpContext.Request.Host}{_urlHelper.ActionContext.HttpContext.Request.PathBase}";
        public bool IsAuthenticated()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        //public PaymentChannel GetChannel => (PaymentChannel)Convert.ToInt32(_accessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "channel").Value);

        public string ApiKey => _accessor.HttpContext.Request.Headers.FirstOrDefault(x => x.Key == "apikey").Value;
        public string AuthToken => _accessor.HttpContext.Request.Headers.TryGetValue("Authorization", out var headerValue) ?
         headerValue.First().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1] : string.Empty;
        public IEnumerable<Claim> GetClaimsIdentity()
        {
            return _accessor.HttpContext.User.Claims;
        }

        public string OS()
        {
            throw new NotImplementedException();
        }
    }
}
