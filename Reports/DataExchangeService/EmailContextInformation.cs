using System;

namespace DataExchangeService
{
    public class EmailContextInformation
    {
        private const string _FILEPATH = "EmailInformation.txt";

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
            _subject = "Your Recent Purchase on Amazon.com of {0}";
            _body = "Dear Customer, \n"
                + "Thank you for purchasing T-Tek products on Amazon.com. We strive to offer you the best value and service possible. \n\n"
                + "Got 2 minutes? \n"
                + "We would love to hear about your experience of our product. \n"
                + "Please can you leave an Amazon Product Review here: \n"
                + "https://www.amazon.com/review/create-review?asin={0}#" + "\n\n"
                + "Have any issues?\n"
                + "If you have any problem, please contact us first before leaving the review.\n"
                + "Just reply to this email and we’ll Get Right on the case. \n\n"
                + "Sincerely,\n"
                + "T-Tek Customer Support";

        }

    }
}
