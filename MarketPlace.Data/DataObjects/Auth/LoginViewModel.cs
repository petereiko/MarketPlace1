using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.DataObjects.Auth
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]

        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
