/*******************************************************************************
 * Copyright 2009-2017 Amazon Services. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"); 
 *
 * You may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 * This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 * specific language governing permissions and limitations under the License.
 *******************************************************************************
 * Marketplace Web Service Orders
 * API Version: 2013-09-01
 * Library Version: 2017-02-22
 * Generated: Thu Mar 02 12:41:05 UTC 2017
 */

using System;
using System.Collections.Generic;
using DataExchangeService;
using MarketplaceWebServiceOrders.Model;


namespace MarketplaceWebServiceOrders
{

    /// <summary>
    /// Runnable sample code to demonstrate usage of the C# client.
    ///
    /// To use, import the client source as a console application,
    /// and mark this class as the startup object. Then, replace
    /// parameters below with sensible values and run.
    /// </summary>
    /// 
    //_sellerId = "A380610PV1XE6A";
    //_MWSAuthToken = "amzn.mws.76aeb40f-2625-ef1b-7942-f41976b59227";
    //_accessKey = "AKIAIKYYTE7TYRWSAIEA";
    //_secretKey = "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";
    public class MarketplaceWebServiceOrdersEntity
    {
        // TODO: Set the below configuration variables before attempting to run
        private string _sellerId = "A380610PV1XE6A";
        private string _MWSAuthToken = "amzn.mws.76aeb40f-2625-ef1b-7942-f41976b59227";


        // Developer AWS access key
        private string _accessKey = "AKIAIKYYTE7TYRWSAIEA";

        // Developer AWS secret key
        private string _secretKey = "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";

        // The client application name
        private string _appName = "T-Tek Tool";

        // The client application version
        private string _appVersion = "1.0";

        private MarketplaceWebServiceOrdersEntity sample;

        // The endpoint for region service and version (see developer guide)
        // ex: https://mws.amazonservices.com
        private const string _serviceURL = "https://mws.amazonservices.com";

        private static MarketplaceWebServiceOrders client = null;

        public static MarketplaceWebServiceOrders GetClient(ServiceCliamDefinition serviceCliamDefinition)
        {
            if (client == null)
            {
                MarketplaceWebServiceOrdersConfig config = new MarketplaceWebServiceOrdersConfig();
                config.ServiceURL = _serviceURL;
                client = new MarketplaceWebServiceOrdersClient(serviceCliamDefinition.AccessKey, serviceCliamDefinition.SecretKey, "T-Tek", "1.0", config);

            }
            return client;
        }



        public GetOrderResponse InvokeGetOrder(ServiceCliamDefinition serviceCliamDefinition, string orderId)
        {
            // Create a request.
            GetOrderRequest request = new GetOrderRequest();

            request.SellerId = serviceCliamDefinition.SellerId;

            request.MWSAuthToken = serviceCliamDefinition.AuthToken;
            List<string> amazonOrderId = new List<string>();
            amazonOrderId.Add(orderId);
            request.AmazonOrderId = amazonOrderId;
            return client.GetOrder(request);
        }

        public GetServiceStatusResponse InvokeGetServiceStatus()
        {
            // Create a request.
            GetServiceStatusRequest request = new GetServiceStatusRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            return client.GetServiceStatus(request);
        }

        public static ListOrderItemsResponse InvokeListOrderItems(ServiceCliamDefinition serviceCliamDefinition, string orderId)
        {
            // Create a request.
            ListOrderItemsRequest request = new ListOrderItemsRequest();

            request.SellerId = serviceCliamDefinition.SellerId;

            request.MWSAuthToken = serviceCliamDefinition.AuthToken;

            request.AmazonOrderId = orderId;
            return GetClient(serviceCliamDefinition).ListOrderItems(request);
        }

        public ListOrderItemsByNextTokenResponse InvokeListOrderItemsByNextToken()
        {
            // Create a request.
            ListOrderItemsByNextTokenRequest request = new ListOrderItemsByNextTokenRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string nextToken = "example";
            request.NextToken = nextToken;
            return client.ListOrderItemsByNextToken(request);
        }

        public static ListOrdersResponse InvokeListOrdersByDateTime(ServiceCliamDefinition serviceCliamDefinition, DateTime createdAfterDateTime, DateTime createdBeforeDateTime)
        {



            ListOrdersRequest request = new ListOrdersRequest()
            {
                SellerId = serviceCliamDefinition.SellerId,
                MWSAuthToken = serviceCliamDefinition.AuthToken,
                CreatedAfter = createdAfterDateTime,
                CreatedBefore = createdBeforeDateTime

            };

            List<string> marketplaceId = new List<string>();
            marketplaceId.Add(serviceCliamDefinition.MarketplaceId);
            request.MarketplaceId = marketplaceId;



            return GetClient(serviceCliamDefinition).ListOrders(request);
        }

        public static ListOrdersResponse InvokeListOrders(ServiceCliamDefinition serviceCliamDefinition)
        {
            // Create a request.
            ListOrdersRequest request = new ListOrdersRequest();

            request.SellerId = serviceCliamDefinition.SellerId;


            request.MWSAuthToken = serviceCliamDefinition.AuthToken;
            DateTime createdAfter = new DateTime(2017, 7, 19);
            request.CreatedAfter = createdAfter;
            /*DateTime createdBefore = new DateTime();
            request.CreatedBefore = createdBefore;
            DateTime lastUpdatedAfter = new DateTime();
            request.LastUpdatedAfter = lastUpdatedAfter;
            DateTime lastUpdatedBefore = new DateTime();
            request.LastUpdatedBefore = lastUpdatedBefore;
            List<string> orderStatus = new List<string>();
            request.OrderStatus = orderStatus;*/
            List<string> marketplaceId = new List<string>();
            marketplaceId.Add("ATVPDKIKX0DER");
            request.MarketplaceId = marketplaceId;
            /*List<string> fulfillmentChannel = new List<string>();
            request.FulfillmentChannel = fulfillmentChannel;
            List<string> paymentMethod = new List<string>();
            request.PaymentMethod = paymentMethod;
            string buyerEmail = "example";
            request.BuyerEmail = buyerEmail;
            string sellerOrderId = "example";
            request.SellerOrderId = sellerOrderId;
            decimal maxResultsPerPage = 1;
            request.MaxResultsPerPage = maxResultsPerPage;
            List<string> tfmShipmentStatus = new List<string>();
            request.TFMShipmentStatus = tfmShipmentStatus;*/
            return GetClient(serviceCliamDefinition).ListOrders(request);
        }

        public ListOrdersByNextTokenResponse InvokeListOrdersByNextToken()
        {
            // Create a request.
            ListOrdersByNextTokenRequest request = new ListOrdersByNextTokenRequest();
            string sellerId = "example";
            request.SellerId = sellerId;
            string mwsAuthToken = "example";
            request.MWSAuthToken = mwsAuthToken;
            string nextToken = "example";
            request.NextToken = nextToken;
            return client.ListOrdersByNextToken(request);
        }

        
    }
}
