using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Auth
{
    public interface IAuthUser
    {
        string Name { get; }
        string ApiKey { get; }
        string AuthToken { get; }
        string EmailAddress { get; }
        string UserId { get; }
        string IPAddress { get; }
        bool Authenticated { get; }
        bool IsAuthenticated();
        IEnumerable<Claim> GetClaimsIdentity();
        string HostBaseUrl { get; }
        //PaymentChannel GetChannel { get; }
        string UserCategory { get; }
    }
}
