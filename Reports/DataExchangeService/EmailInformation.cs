namespace DataExchangeService
{
    public class EmailInformation
    {
        private const string _FILEPATH = "EmailInformation.txt";

        private string _emailAddress;
        private string _password;
        private string _subject;
        private string _body;


        public string EmailAddress
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Subject
        {
            get;
            set;
        }

        public string body
        {
            get;
            set;
        }


    }
}
