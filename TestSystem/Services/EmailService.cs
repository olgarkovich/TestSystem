using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TestSystem.Services
{
    public class EmailService
    {
        public void Send(string to_address, string body, string subject)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("ujhkiyjh@gmail.com", subject);
            message.To.Add(to_address);
            message.Subject = "Test";
            message.Body = body;
            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            {
                client.Credentials = new NetworkCredential("ujhkiyjh@gmail.com", "qweR123$");
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
            }
        }
    }
}