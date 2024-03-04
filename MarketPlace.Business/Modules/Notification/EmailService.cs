using MarketPlace.Data.DataObjects.ApplicationConfig;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Business.Modules.Notification
{
    public class EmailService:IEmailService
    {
        private readonly AppSetting _appSettings;
        private readonly ILogger<EmailService> _logger;
        public EmailService(IOptions<AppSetting> appSettings, ILogger<EmailService> logger)
        {
            _appSettings = appSettings.Value;
            _logger = logger;
        }

        public async Task Send(string recipient, string subject, string msg)
        {
            var emailSetting = _appSettings.EmailSetting;
            try
            {
                using (var smtp = new SmtpClient())
                {
                    smtp.Host = emailSetting.Smtp;
                    smtp.Port = emailSetting.Port;
                    smtp.EnableSsl = emailSetting.EnableSsl;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(emailSetting.EmailCredential.Email, emailSetting.EmailCredential.Password);

                    // Create and send the email
                    using (var message = new MailMessage(emailSetting.EmailCredential.Email, recipient))
                    {
                        message.Subject = subject;
                        message.Body = msg;
                        message.IsBodyHtml = false;
                        try
                        {
                            await smtp.SendMailAsync(message);
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError(ex.Message, ex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
            
        }
    }
}
