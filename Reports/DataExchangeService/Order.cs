using System;

namespace DataExchangeService
{
    public class Order
    {
        private Item _item = null;
        private DateTime _purchaseDate;
        public string Email
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string OrderId
        {
            get;
            set;
        }

        public Item Item
        {
            get
            {
                if (_item == null)
                {
                    _item = new Item();
                }
                return _item;
            }
        }

        public float Amount
        {
            get;
            set;
        }

        public DateTime PurchaseDate
        {
            get
            {
                if (_purchaseDate < Convert.ToDateTime("1,1,2000"))
                {
                    PurchaseDate = DateTime.MaxValue;
                }
                return _purchaseDate;
            }
            set
            {
                _purchaseDate = value;
            }
        }
    }
}
