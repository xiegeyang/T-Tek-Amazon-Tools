using System;

namespace DataExchangeService
{
    public class EmailContextInformation
    {
        private const string _FILEPATH = "EmailInformation.txt";
        public const string _IMAGEURL = "https://github.com/xiegeyang/T-Tek-Amazon-Tools/blob/master/Reports/TTekSmartUI/bin/Debug/Images/{0}.png?raw=true";

        private string _emailAddress;
        private string _password;
        private string _subject;
        private string _body;

        public EmailContextInformation()
        {
            _emailAddress = String.Empty;
            _password = String.Empty;
            _subject = String.Empty;
            _body = String.Empty;
        }

        public string EmailAddress
        {
            get
            {
                if (_emailAddress.Equals(string.Empty))
                {
                    InitialEmailContextInformation();
                }
                return _emailAddress;
            }
            set
            {
                _emailAddress = value;
            }
        }

        public string Password
        {
            get
            {
                if (_password.Equals(String.Empty))
                {
                    InitialEmailContextInformation();
                }
                return _password;
            }
            set
            {
                _password = value;
            }

        }

        public string Subject
        {
            get
            {
                if (_subject.Equals(String.Empty))
                {
                    InitialEmailContextInformation();
                }
                return _subject;
            }
            set
            {
                _subject = value;
            }
        }

        public string Body
        {
            get
            {
                if (_body.Equals(String.Empty))
                {
                    InitialEmailContextInformation();
                }
                return _body;
            }
            set
            {
                _body = value;
            }
        }


        private void InitialEmailContextInformation()
        {
            _emailAddress = "xiegeyang@t-tekproduct.com";
            _password = "X199241gy";
            _subject = "{0} did recent purchases from Amazon meet your expectations?";
            _body = " <img src=\"{0}\" height=\"100\" width=\"400\" />"
            + "<br /><br />"
            + "<p><b>Dear Customer,</b>"
            + "<br /><br />"
            + "Thank you for puchasing T-Tek products on Amazon.com. We strive to offer you the best value and service possible."
            + "<br /><br />"
            + "<b>Got 2 minutes?</b>"
            + "<br />"
            + "<table>"
            + "<tr>"
            + "<td>Please leave your product review here:</td>"
            + "<td><a href=\"https://www.amazon.com/review/create-review?asin={1}#\"><img src=\"{2}\" height=\"50\" width=\"172\" /></a></td>"
            + "</tr>"
            + "</table>"
            + "<br /><br />"
            + "<table>"
            + "<tr>"
            + "<td><img src=\"{3}\" height=\"150\" width=\"150\" style=\"float:left\" /></td>"
            + "<td></td><td></td><td></td>"
            + "<td>{4}</td>"
            + "</tr>"
            + "</table>"
            + "<br /><br />"
            + "If you have any issues with your purchase, please contact us first before leaving the review. We're happy to help!"
            + "<br /><br />"
            + "<a href=\"https://www.amazon.com/ss/help/contact/?_encoding=UTF8&orderID={5}&sellerID={6}\">Contact Seller</a>"
            + "<br /><br />"
            + "Sincerely, <br />"
            + "Customer Support Team <br />"
            + "T-Tek Customer Support <br /></p>";

        }


        public string GetEmailBodyContext(ServiceCliamDefinition serviceCliamDefinition, Order order)
        {
            string logoImageUrl = String.Format(_IMAGEURL, "logo");
            string itemImageUrl = String.Format(_IMAGEURL, order.Item.ASIN);
            string reviewStarImageUrl = String.Format(_IMAGEURL, "xinxin");
            return String.Format(Body, logoImageUrl, order.Item.ASIN, reviewStarImageUrl, itemImageUrl, order.Item.Title, order.OrderId, serviceCliamDefinition.SellerId);
        }

        public string GetEmailSubjectContext(Order order)
        {
            return String.Format(Subject, order.Name);
        }
    }
}
