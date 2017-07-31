using System;

namespace DataExchangeService
{
    public class TTekException : Exception
    {
        public ExceptionType ExType
        {
            get;
        }


        public TTekException(string message) : base(message)
        {
        }

        public TTekException(string message, ExceptionType exceptionType) : base(message)
        {
            this.ExType = exceptionType;
        }

    }


    public enum ExceptionType
    {
        LastInvokeDateTimeNotSet = 1
    }


}
