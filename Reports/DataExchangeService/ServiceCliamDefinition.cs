using System;
using System.IO;
using System.Xml;

namespace DataExchangeService
{
    public class ServiceCliamDefinition
    {
        private string _lastInvokeDateTime;
        private const string _FILEPATH = "SellerInfo.txt";

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

        public DateTime LastInvokeDateTime
        {
            get
            {
                if (_lastInvokeDateTime == null || _lastInvokeDateTime == String.Empty)
                {
                    return DateTime.MaxValue;
                }
                return DateTime.Parse(_lastInvokeDateTime);
            }
            set
            {
                _lastInvokeDateTime = value.ToString();
            }
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

        public void SaveToXml()
        {
            if (File.Exists(_FILEPATH))
            {
                File.Delete(_FILEPATH);
            }
            string xmlString = String.Format("<SellerInfo><sellerId>{0}</sellerId>"
                + "<authToken>{1}</authToken>"
                + "<lastInvokeDateTime>{2}</lastInvokeDateTime></SellerInfo>", SellerId, AuthToken, _lastInvokeDateTime);
            File.WriteAllText(_FILEPATH, xmlString);

        }

        public void GetFromXml()
        {
            if (File.Exists(_FILEPATH))
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(File.ReadAllText(_FILEPATH));
                XmlNode list = xDoc.GetElementsByTagName("SellerInfo")[0];

                foreach (XmlNode node in list)
                {
                    if (node.Name == "sellerId")
                    {
                        SellerId = node.InnerText;
                    }
                    if (node.Name == "authToken")
                    {
                        AuthToken = node.InnerText;
                    }
                    if (node.Name == "lastInvokeDateTime")
                    {
                        _lastInvokeDateTime = node.InnerText;
                    }
                }
            }
        }
    }
}
