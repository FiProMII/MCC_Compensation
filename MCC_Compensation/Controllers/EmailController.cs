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
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        public const string RequestSubject = "Compensation Request #";
        public const string RequestResultSubject = "Update on your compensation request";
        public const string TemporaryPasswordSubject = "New Temporary Password #";


        private IWebHostEnvironment _hostingEnvironment;

        public EmailController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public enum EmailType
        {
            CompensationRequest,
            CompensationRequestApproved,
            CompensationRequestRejected,
            TemporaryPassword
        }

        public void SendEmail(EmailType emailType, Employee employeeRecipient, CompensationRequest request)
        {
            var webRoot = _hostingEnvironment.WebRootPath;
            string messageBody = "";

            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Compensation Request Admin", "compensationmcc@gmail.com");
            MailboxAddress to = new MailboxAddress(employeeRecipient.EmployeeName, employeeRecipient.Email);

            message.To.Add(to);
            message.From.Add(from);

            var builder = new BodyBuilder();

            string pathToFile;
            Approval approval;

            switch (emailType)
            {
                case EmailType.CompensationRequest:
                    message.Subject = RequestSubject + DateTime.Now.ToString("MMddyyyyHHmmss");
                    pathToFile = webRoot + Path.DirectorySeparatorChar.ToString() + "Request.html";
                    using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
                    {

                        builder.HtmlBody = SourceReader.ReadToEnd();

                    }
                    messageBody = string.Format(builder.HtmlBody,
                        employeeRecipient.EmployeeName,
                        request.NIK,
                        request.Employee.EmployeeName,
                        request.RequestDate,
                        request.Compensation.CompensationName,
                        "https://localhost:44309/Request/Approval?id=" + request.RequestID
                        );
                    break;
                case EmailType.CompensationRequestApproved:
                    message.Subject = RequestResultSubject;
                    pathToFile = webRoot + Path.DirectorySeparatorChar.ToString() + "RequestApproved.html";
                    approval = request.Approvals.OrderBy(a => a.ApprovalDate).Last();
                    using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
                    {

                        builder.HtmlBody = SourceReader.ReadToEnd();

                    }
                    messageBody = string.Format(builder.HtmlBody,
                        employeeRecipient.EmployeeName,
                        request.Compensation.CompensationName.ToLower(),
                        request.RequestDate,
                        approval.Employee.EmployeeName,
                        approval.Employee.Position.Department.DepartmentName,
                        approval.Employee.Email
                        );
                    break;
                case EmailType.CompensationRequestRejected:
                    message.Subject = RequestResultSubject;
                    pathToFile = webRoot + Path.DirectorySeparatorChar.ToString() + "RequestRejected.html";
                    approval = request.Approvals.OrderBy(a => a.ApprovalDate).Last();
                    using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
                    {

                        builder.HtmlBody = SourceReader.ReadToEnd();

                    }
                    messageBody = string.Format(builder.HtmlBody,
                        employeeRecipient.EmployeeName,
                        request.Compensation.CompensationName.ToLower(),
                        request.RequestDate,
                        approval.Employee.EmployeeName,
                        approval.Employee.Position.Department.DepartmentName,
                        approval.Employee.Email,
                        approval.Note
                        );
                    break;
                case EmailType.TemporaryPassword:
                    message.Subject = TemporaryPasswordSubject + DateTime.Now.ToString("MMddyyyyHHmmss");
                    pathToFile = webRoot + Path.DirectorySeparatorChar.ToString() + "ForgotPassword.html";
                    using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
                    {

                        builder.HtmlBody = SourceReader.ReadToEnd();

                    }
                    messageBody = string.Format(builder.HtmlBody,
                        employeeRecipient.EmployeeName,
                        employeeRecipient.Account.Password,
                        "https://localhost:44309/"
                        );
                    break;
            }

            message.Body = new TextPart("html") { Text = messageBody };

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
