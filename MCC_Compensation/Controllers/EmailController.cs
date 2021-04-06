using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        public const string RequestSubject = "Compensation Request";
        public const string TemporaryPasswordSubject = "New Temporary Password";
        public const string RequestBody = "Please verify this compensation request by clicking this link: https://localhost:44309/Request/Approval?id=";
        public const string TemporaryPasswordBody = "Login with your new temporary password: ";

        private IWebHostEnvironment _hostingEnvironment;

        public EmailController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public enum EmailType
        {
            CompensationRequest,
            TemporaryPassword
        }

        public void SendEmail(string recipient, EmailType emailType, string bodyParam)
        {
            var webRoot = _hostingEnvironment.WebRootPath;
            var pathToFile = webRoot
                            + Path.DirectorySeparatorChar.ToString()
                            + "tes.html";

            var builder = new BodyBuilder();

            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
            {

                builder.HtmlBody = SourceReader.ReadToEnd();

            }            
            
            //string to = recipient;
            //string from = "compensationmcc@gmail.com";
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Admin", "compensationmcc@gmail.com");
            MailboxAddress to = new MailboxAddress("User", recipient);
            message.To.Add(to);
            message.From.Add(from);
            message.Body = builder.ToMessageBody();

            message.Subject = "This is email subject";


            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            client.Authenticate("compensationmcc@gmail.com", "compensationmcc2021");
            
            try
            {
                client.Send(message);
                client.Disconnect(true);
                client.Dispose();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
