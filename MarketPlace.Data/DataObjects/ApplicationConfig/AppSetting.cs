using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.DataObjects.ApplicationConfig
{
    public class AppSetting
    {
        public string AppName { get; set; }
        public string BaseUrl { get; set; }
        public SmsSetting SmsSetting { get; set; }
        public EmailSetting EmailSetting { get; set; }
    }

    public class SmsSetting
    {
        public string key { get; set; }
        public int campaign { get; set; }
        public int routeid { get; set; }
        public string type { get; set; }
        public string senderid { get; set; }
        public string uri { get; set; }
    }

    public class EmailSetting
    {
        public string Smtp { get; set; }
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public EmailCredential EmailCredential { get; set; }
    }

    public class EmailCredential
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
