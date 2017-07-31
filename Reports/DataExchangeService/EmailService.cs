using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace DataExchangeService
{
    public class EmailService
    {






        public static void SendEmailByOrderCollection(ServiceCliamDefinition serviceCliamDefinition, OrderCollection orderCollection, TextBox textBox)
        {
            textBox.Text = String.Empty;
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
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 3000
            };

            foreach (Order order in orderCollection)
            {
                textBox.Text += String.Format("Sending email to {0}...\n", order.Email);
                MailAddress toAddress = new MailAddress(order.Email);
                string subject = emailContextInformation.GetEmailSubjectContext(order);
                string body = emailContextInformation.GetEmailBodyContext(serviceCliamDefinition, order);
                AlternateView avHtml = AlternateView.CreateAlternateViewFromString(body, null, MediaTypeNames.Text.Html);

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                })
                {
                    message.AlternateViews.Add(avHtml);
                    message.IsBodyHtml = true;
                    smtp.Send(message);

                    textBox.Text += String.Format("Success!\n");
                }

            }


        }


        public static void SendEmailByCustomizeEmail(ServiceCliamDefinition serviceCliamDefinition, string toEmailAddress, string emailSubject, string emailBody)
        {
            EmailContextInformation emailContextInformation = new EmailContextInformation();
            MailAddress fromAddress = new MailAddress(emailContextInformation.EmailAddress, "T-Tek Product Team");
            MailAddress toAddress = new MailAddress(toEmailAddress, "Customer");
            string subject = String.Format(emailSubject, "xiegeyang");

            string fromPassword = emailContextInformation.Password;
            string mainBody = String.Format(emailBody, "B06W2HZQ86", "T-Tek Product Cube Relieves Stress And Anxiety for Children and Adults Anxiety Attention Toy", "103-7133341-8905855", serviceCliamDefinition.SellerId);


            AlternateView avHtml = AlternateView.CreateAlternateViewFromString(mainBody, null, MediaTypeNames.Text.Html);


            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };



            using (var mail = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
            })
            {

                mail.AlternateViews.Add(avHtml);
                mail.IsBodyHtml = true;
                smtp.Send(mail);
            }



        }

    }
}
