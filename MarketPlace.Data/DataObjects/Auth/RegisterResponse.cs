using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.DataObjects.Auth
{
    public class RegisterResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public bool HasError { get; set; }
    }
}
