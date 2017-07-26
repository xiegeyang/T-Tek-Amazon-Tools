using System;
using System.Threading;
using System.Xml;
using DataExchangeService;
using MarketplaceWebServiceOrders.Model;

namespace MarketplaceWebServiceOrders
{
    public class MarketplaceWebServiceOrdersDataAccess
    {
        public static OrderCollection InvokeListOrdersDetailByDateTime(ServiceCliamDefinition serviceCliamDefinition, DateTime createdAfterDateTime, DateTime createdBeforeDateTime)
        {
            OrderCollection orderCollection = new OrderCollection();
            XmlDocument xOrderList = getListOrdersByDateTimeXmlData(serviceCliamDefinition, createdAfterDateTime, createdBeforeDateTime);
            XmlNodeList orderList = xOrderList.GetElementsByTagName("Order");

            foreach (XmlNode order in orderList)
            {
                string orderId = String.Empty;
                string buyerEmail = String.Empty;
                string name = String.Empty;

                foreach (XmlNode informationType in order)
                {
                    if (informationType.Name == "AmazonOrderId")
                    {
                        orderId = informationType.InnerText;
                    }
                    if (informationType.Name == "BuyerEmail")
                    {
                        buyerEmail = informationType.InnerText;
                    }
                    if (informationType.Name == "ShippingAddress")
                    {
                        foreach (XmlNode inforType in informationType)
                        {
                            if (inforType.Name == "Name")
                            {
                                name = inforType.InnerText;
                            }
                        }
                    }

                }
                if (!buyerEmail.Equals(String.Empty))
                {
                    DataExchangeService.Order orderDetail = GetDetailOrder(serviceCliamDefinition, orderId, buyerEmail, name);
                    if (orderDetail != null)
                    {
                        orderCollection.Add(orderDetail);
                    }
                }
            }
            return orderCollection;
        }

        private static DataExchangeService.Order GetDetailOrder(ServiceCliamDefinition serviceCliamDefinition, string orderId, string buyerEmail, string name)
        {
            DataExchangeService.Order orderDetail = new DataExchangeService.Order();
            orderDetail.OrderId = orderId;
            orderDetail.Email = buyerEmail;
            orderDetail.Name = name;
            XmlDocument xOrder = GetListOrderItemsXmlData(serviceCliamDefinition, orderId);
            string ASIN = xOrder.GetElementsByTagName("ASIN")[0].InnerText;

            if (!(ASIN.Equals("B071K61DCV") || ASIN.Equals("B071W2F29J") || ASIN.Equals("B071WV3CSF") || ASIN.Equals("B071ZHKNKH") ||
                ASIN.Equals("B072K2T1TN") || ASIN.Equals("B0723CV3HT") || ASIN.Equals("B0739M71H8") || ASIN.Equals("B0746B61V6") ||
                ASIN.Equals("B07176P1VR")))
            {
                return null;
            }

            orderDetail.Item.ASIN = ASIN;
            orderDetail.Item.Title = xOrder.GetElementsByTagName("Title")[0].InnerText;
            return orderDetail;
        }

        private static XmlDocument GetListOrderItemsXmlData(ServiceCliamDefinition serviceCliamDefinition, string orderId)
        {
            IMWSResponse OrderResponse = null;
            OrderResponse = MarketplaceWebServiceOrdersEntity.InvokeListOrderItems(serviceCliamDefinition, orderId);

            string orderResponesXML = OrderResponse.ToXML();
            XmlDocument xOrderList = new XmlDocument();
            xOrderList.LoadXml(orderResponesXML);
            Thread.Sleep(2000);
            return xOrderList;
        }

        private static XmlDocument getListOrdersByDateTimeXmlData(ServiceCliamDefinition serviceCliamDefinition, DateTime createdAfterDateTime, DateTime createdBeforeDateTime)
        {
            IMWSResponse listOrdersResponse = null;
            listOrdersResponse = MarketplaceWebServiceOrdersEntity.InvokeListOrdersByDateTime(serviceCliamDefinition, createdAfterDateTime, createdBeforeDateTime);

            string responseXml = listOrdersResponse.ToXML();
            XmlDocument xOrderList = new XmlDocument();
            xOrderList.LoadXml(responseXml);
            return xOrderList;
        }
    }
}
