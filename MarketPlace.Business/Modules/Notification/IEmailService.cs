using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Notification
{
    public interface IEmailService
    {
        Task Send(string recipient, string subject, string msg);
    }
}
