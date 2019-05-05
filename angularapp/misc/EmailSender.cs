using angularapp.Repositories;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace angularapp.misc
    {
    public static class EmailSender
        {
        static async Task<Response> Execute(string toEmail, string subject, string message)
            {
            var apiKey = Properties.Resources.ResourceManager.GetString("ApiKey");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("support@test.com", "Support");
            var to = new EmailAddress(toEmail, "Customer");
            var htmlContent = "<strong>" + message + "</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, message, htmlContent);
            string uniqueIdentifier = Guid.NewGuid().ToString("N").Trim();
            msg.AddGlobalCustomArg("identifier", uniqueIdentifier);
            var response = await client.SendEmailAsync(msg);
            EmailRepository emrepo = new EmailRepository();
            emrepo.SaveEmail(new Models.Email { Identifier = uniqueIdentifier, ToEmail = toEmail, Status = response.StatusCode.ToString(), Subject = subject, Message = message });
            return response;
            }
        public static Response SendEmail(string toEmail, string subject, string message)
            {
            return Execute(toEmail, subject, message).Result;
            }
        }

    }
