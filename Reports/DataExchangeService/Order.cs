namespace DataExchangeService
{
    public class Order
    {
        private Item _item = null;

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
    }
}
