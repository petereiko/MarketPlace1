using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public ApplicationUserRole()
            : base()
        { }
    }
}
