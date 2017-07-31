using System;
using System.Data;
using System.Data.SqlClient;

namespace DataExchangeService.Orders
{
    public class OrdersDataRecordAccess
    {
        public static void saveOrderCollection(ServiceCliamDefinition serviceCliamDefinition, OrderCollection orderCollection)
        {
            string statment = GetsaveOrderCollectionStatment(orderCollection);
            using (DataAccess dataAccess = new DataAccess())
            {
                ExecuteSaveOrderCollectionStatment(serviceCliamDefinition, dataAccess, statment, orderCollection);
            }

        }

        private static void ExecuteSaveOrderCollectionStatment(ServiceCliamDefinition serviceCliamDefinition, DataAccess dataAccess, string statment, OrderCollection orderCollection)
        {
            foreach (Order order in orderCollection)
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = statment;
                    command.CommandType = CommandType.Text;
                    command.Connection = dataAccess.Connection;
                    command.Parameters.AddWithValue("@orderID", order.OrderId);
                    command.Parameters.AddWithValue("@emailAddress", order.Email);
                    command.Parameters.AddWithValue("@asin", order.Item.ASIN);
                    command.Parameters.AddWithValue("@customerName", order.Name);
                    command.Parameters.AddWithValue("@amount", order.Amount);
                    command.Parameters.AddWithValue("@itemTitle", order.Item.Title);
                    command.Parameters.AddWithValue("@purchaseDate", order.PurchaseDate);
                    command.Parameters.AddWithValue("@sellerId", serviceCliamDefinition.SellerId);
                    command.Parameters.AddWithValue("@emailStatus", 0);
                    command.ExecuteNonQuery();
                }
            }

        }

        private static string GetsaveOrderCollectionStatment(OrderCollection orderCollection)
        {
            string statment = "INSERT INTO Order_Master"
                + " (orderId, emailAddress, asin, customerName, amount, itemTitle, purchaseDate, sellerId, emailStatus)"
                + " VALUES"
                + " (@orderID, @emailAddress, @asin, @customerName, @amount, @itemTitle, @purchaseDate, @sellerId, @emailStatus)";
            return statment;
        }

        public static OrderCollection GetOrderCollection(ServiceCliamDefinition serviceCliamDefinition)
        {
            OrderCollection orderCollection = new OrderCollection();
            string statment = GetOrderCollectionStatment();
            using (DataAccess dataAccess = new DataAccess())
            {
                ExecuteGetOrderCollentionStatment(serviceCliamDefinition, dataAccess, statment, orderCollection);
            }
            return orderCollection;

        }

        private static void ExecuteGetOrderCollentionStatment(ServiceCliamDefinition serviceCliamDefinition, DataAccess dataAccess, string statment, OrderCollection orderCollection)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = statment;
            command.CommandType = CommandType.Text;
            command.Parameters.Add("@sellerId", serviceCliamDefinition.SellerId);
            command.Connection = dataAccess.Connection;

            IDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();

                order.Name = (string)reader.GetValue(3);
                order.Email = (string)reader.GetValue(1);
                order.OrderId = (string)reader.GetValue(0);
                order.Amount = (float)Convert.ToDouble(reader.GetValue(4));
                order.Item.ASIN = (string)reader.GetValue(2);
                order.Item.Title = (string)reader.GetValue(5);
                order.PurchaseDate = (DateTime)reader.GetValue(6);
                orderCollection.Add(order);
            }
        }

        private static string GetOrderCollectionStatment()
        {
            return "SELECT orderId, emailAddress, asin, customerName, amount, itemTitle, purchaseDate"
                + " FROM Order_Master"
                + " WHERE sellerId = @sellerId";
        }
    }
}
