using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;


namespace AboutMe.Service
{
	public class EmailSender
	{
		public static void SendMail(string toEmail, string user, string text)
		{
			var apiKey = Environment.GetEnvironmentVariable("SendGridAPI");
			var fromEmail = Environment.GetEnvironmentVariable("FromEmail");


			var client = new SendGridClient(apiKey);
            var from = new EmailAddress(fromEmail, user);
			var to = new EmailAddress(toEmail, "User 2");

			var msg = MailHelper.CreateSingleEmail(
				from, to, "subject", text, "HTML content");

			var result = client.SendEmailAsync(msg);
        }
	}
}

