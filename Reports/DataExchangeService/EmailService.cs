using System;
using System.Net;
using System.Net.Mail;

namespace DataExchangeService
{
    public class EmailService
    {
        public static void SendEmail(OrderCollection orderCollection)
        {
            EmailContextInformation emailContextInformation = new EmailContextInformation();
            MailAddress fromAddress = new MailAddress(emailContextInformation.EmailAddress, "T-Tek Product Team");

            string fromPassword = emailContextInformation.Password;


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            foreach (Order order in orderCollection)
            {
                MailAddress toAddress = new MailAddress("5ktg4qglw5598s3@marketplace.amazon.com", "Customer");
                string subject = String.Format(emailContextInformation.Subject, order.Item.Title);
                string body = String.Format(emailContextInformation.Body, order.Item.ASIN);
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
            }


        }
    }
}
