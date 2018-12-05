using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TasteRestaurant.Areas.Identity.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //Send email with subject and the htmlMessage to the received email
            

            //01. Create a client, the host is "gmail" and the port is "578"
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            //02. Specify Client Credentials :
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("atanasskambitovv@gmail.com", "LELEMALE!!!");
            client.EnableSsl = true;


            //03. Create the Message
            MailMessage mailMessage = new MailMessage();

            //04. Assign everything to the message
            mailMessage.From = new MailAddress("atanasskambitovv@gmail.com");
            mailMessage.Body = htmlMessage;
            mailMessage.Subject = subject;  
            mailMessage.To.Add(email);
            mailMessage.IsBodyHtml = true;


            //05. Send the message
            client.Send(mailMessage);
            
            return Task.CompletedTask;
        }
    }
}
