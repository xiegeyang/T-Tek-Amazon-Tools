using System;
using System.Collections.Generic;

namespace DataExchangeService
{
    public class OrderCollection : List<Order>
    {
        public List<Exception> Errors = new List<Exception>();

        public void AddError(Exception ex)
        {
            Errors.Add(ex);
        }
    }
}
