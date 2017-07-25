using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace DataExchangeService
{
    public class EmailService
    {
        private const string _htmlLogo = "<img src=\"https://github.com/xiegeyang/T-Tek-Amazon-Tools/blob/master/Reports/TTekSmartUI/bin/Debug/logo.jpg?raw=true\" height=\"100\" width=\"400\" />";
        private const string _htmlMainBody =
            "<br /><br />"
            + "<p><b>Dear Customer,</b>"
            + "<br /><br />"
            + "Thank you for puchasing T-Tek products on Amazon.com. We strive to offer you the best value and service possible."
            + "<br /><br />"
            + "<b>Got 2 minutes?</b>"
            + "<br />"
            + "<table>"
            + "<tr>"
            + "<td>Please leave your product review here:</td>"
            + "<td><a href=\"https://www.amazon.com/review/create-review?asin={0}#\"><img src=\"https://raw.githubusercontent.com/xiegeyang/T-Tek-Amazon-Tools/master/Reports/TTekSmartUI/bin/Debug/reviewstar.png\" height=\"50\" width=\"172\" /></a></td>"
            + "</tr>"
            + "</table>"
            + "<br /><br />"
            + "<table>"
            + "<tr>"
            + "<td><img src=\"https://github.com/xiegeyang/T-Tek-Amazon-Tools/blob/master/Reports/TTekSmartUI/bin/Debug/fidgetcube.jpg?raw=true\" height=\"150\" width=\"150\" style=\"float:left\" /></td>"
            + "<td></td><td></td><td></td>"
            + "<td>{1}</td>"
            + "</tr>"
            + "</table>"
            + "<br /><br />"
            + "If you have any issues with your purchase, please contact us first before leaving the review. We're happy to help!"
            + "<br /><br />"
            + "<a href=\"https://www.amazon.com/ss/help/contact/?_encoding=UTF8&orderID={2}&sellerID={3}\">Contact Seller</a>"
            + "<br /><br />"
            + "Sincerely, <br />"
            + "Customer Support Team <br />"
            + "T-Tek Customer Support <br /></p>";




        public static void SendEmailByOrderCollection(OrderCollection orderCollection)
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


        public static void SendEmailByCustomizeEmail(string toEmailAddress, string emailSubject, string emailBody)
        {
            EmailContextInformation emailContextInformation = new EmailContextInformation();
            MailAddress fromAddress = new MailAddress(emailContextInformation.EmailAddress, "T-Tek Product Team");
            MailAddress toAddress = new MailAddress(toEmailAddress, "Customer");
            string subject = String.Format(emailSubject, "xiegeyang");

            string fromPassword = emailContextInformation.Password;



            string headerLogo = String.Format(_htmlLogo);


            string mainBody = String.Format(_htmlMainBody, "B06W2HZQ86", "T-Tek Product Cube Relieves Stress And Anxiety for Children and Adults Anxiety Attention Toy", "103-7133341-8905855", "A380610PV1XE6A");

            string htmlBody = headerLogo + mainBody;
            AlternateView avHtml = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);


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

        private string getImagePath(string ASIN)
        {
            string path = "< img src = \"{0}.jpg\" alt = \"Mountain View\" style = \"width:304px;height:228px;\" >";
            return String.Format(path, ASIN);
        }
    }
}
