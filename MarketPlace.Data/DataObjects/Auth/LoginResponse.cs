using MarketPlace.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.DataObjects.Auth
{
    public class LoginResponse
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public LoginStatus LoginStatus { get; set; }
        public ApplicationUserViewModel ApplicationUser { get; set; }
    }
}
