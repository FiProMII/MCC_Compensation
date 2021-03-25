using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        public const string RequestSubject = "Compensation Request";
        public const string TemporaryPasswordSubject = "New Temporary Password";
        public const string RequestBody = "Please verify this compensation request by clicking this link: ";
        public const string TemporaryPasswordBody = "Login with your new temporary password: ";

        public enum EmailType
        {
            CompensationRequest,
            TemporaryPassword
        }

        public void SendEmail(string recipient, EmailType emailType, string bodyParam)
        {
            string to = recipient;   
            string from = "mekarbunga2021@gmail.com";
            MailMessage message = new MailMessage(from, to);

            switch (emailType)
            {
                case EmailType.CompensationRequest:
                    message.Body = RequestBody + bodyParam;
                    message.Subject = RequestSubject;
                    break;
                case EmailType.TemporaryPassword:
                    message.Body = TemporaryPasswordBody + bodyParam;
                    message.Subject = TemporaryPasswordSubject;
                    break;
            }

            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);  
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("mekarbunga2021@gmail.com", "mekarbunga123");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
