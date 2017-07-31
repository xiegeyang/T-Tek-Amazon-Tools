using System;
using System.Threading;
using System.Xml;
using DataExchangeService;
using MarketplaceWebServiceOrders.Model;

namespace MarketplaceWebServiceOrders
{
    public class MarketplaceWebServiceOrdersDataAccess
    {
        public static OrderCollection InvokeListOrdersDetailByNextDate(ServiceCliamDefinition serviceCliamDefinition)
        {
            OrderCollection orderCollection = null;
            try
            {
                if (serviceCliamDefinition != null)
                {
                    if (serviceCliamDefinition.LastInvokeDateTime == DateTime.MaxValue)
                    {
                        throw new TTekException("You do not have Last Invoke Date Time Value", ExceptionType.LastInvokeDateTimeNotSet);
                    }
                    DateTime createdBeforeDateTime = DateTime.Now.AddMinutes(-2);
                    orderCollection = InvokeListOrdersDetailByDateTime(serviceCliamDefinition, serviceCliamDefinition.LastInvokeDateTime, createdBeforeDateTime);
                    serviceCliamDefinition.LastInvokeDateTime = createdBeforeDateTime;

                }
            }
            catch (Exception ex)
            {
                orderCollection = new OrderCollection();
                orderCollection.AddError(ex);
            }
            return orderCollection;

        }

        public static OrderCollection InvokeListOrdersDetailByDateTime(ServiceCliamDefinition serviceCliamDefinition, DateTime createdAfterDateTime, DateTime createdBeforeDateTime)
        {
            if (serviceCliamDefinition == null)
            {
                return new OrderCollection();
            }


            OrderCollection orderCollection = new OrderCollection();
            XmlDocument xOrderList = getListOrdersByDateTimeXmlData(serviceCliamDefinition, createdAfterDateTime, createdBeforeDateTime);

            XmlNodeList orderList = xOrderList.GetElementsByTagName("Order");

            foreach (XmlNode order in orderList)
            {
                DataExchangeService.Order orderDetail = new DataExchangeService.Order();

                foreach (XmlNode informationType in order)
                {
                    GetBasicOrderInformation(informationType, orderDetail);
                }
                if (orderDetail.Email != null && !orderDetail.Email.Equals(String.Empty))
                {
                    GetDetailOrderInformation(serviceCliamDefinition, orderDetail);
                    if (orderDetail != null)
                    {
                        orderCollection.Add(orderDetail);
                    }
                }
            }
            return orderCollection;
        }

        public static void GetBasicOrderInformation(XmlNode informationType, DataExchangeService.Order orderDetail)
        {


            if (informationType.Name == "AmazonOrderId")
            {
                orderDetail.OrderId = informationType.InnerText;
            }
            if (informationType.Name == "BuyerEmail")
            {
                orderDetail.Email = informationType.InnerText;
            }
            if (informationType.Name == "PurchaseDate")
            {
                orderDetail.PurchaseDate = DateTime.ParseExact(informationType.InnerText, "MM/dd/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (informationType.Name == "ShippingAddress")
            {
                foreach (XmlNode inforType in informationType)
                {
                    if (inforType.Name == "Name")
                    {
                        orderDetail.Name = inforType.InnerText;
                    }
                }
            }
            if (informationType.Name == "OrderTotal")
            {
                foreach (XmlNode inforType in informationType)
                {
                    if (inforType.Name == "Amount")
                    {
                        orderDetail.Amount = (float)Convert.ToDouble(inforType.InnerText);
                    }
                }
            }
        }

        public static void GetDetailOrderInformation(ServiceCliamDefinition serviceCliamDefinition, DataExchangeService.Order orderDetail)
        {

            XmlDocument xOrder = GetListOrderItemsXmlData(serviceCliamDefinition, orderDetail.OrderId);

            string ASIN = xOrder.GetElementsByTagName("ASIN")[0].InnerText;

            orderDetail.Item.ASIN = ASIN;
            orderDetail.Item.Title = xOrder.GetElementsByTagName("Title")[0].InnerText;
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

        public static XmlDocument getListOrdersByDateTimeXmlData(ServiceCliamDefinition serviceCliamDefinition, DateTime createdAfterDateTime, DateTime createdBeforeDateTime)
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
