using MarketPlace.Data.DataObjects.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Auth
{
    public interface IAccountService
    {
        Task<LoginResponse> Login(LoginViewModel model);

        Task SignOut();
        Task<RegisterResponse> Register(RegisterViewModel payload);
    }
}
