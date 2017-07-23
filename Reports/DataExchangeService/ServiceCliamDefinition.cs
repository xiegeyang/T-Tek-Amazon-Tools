namespace DataExchangeService
{
    public class ServiceCliamDefinition
    {
        public string SellerId
        {
            set;
            get;
        }

        public string AuthToken
        {
            set;
            get;
        }

        public string AccessKey
        {
            set;
            get;
        }

        public string SecretKey
        {
            set;
            get;
        }

        public string MarketplaceId
        {
            set;
            get;
        }

        public ServiceCliamDefinition()
        {
        }

        public ServiceCliamDefinition(string sellerId, string authToken, string accessKey, string secretKey, string marketplaceId)
        {
            this.SellerId = sellerId;
            this.AuthToken = authToken;
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
            this.MarketplaceId = marketplaceId;
        }
    }
}
