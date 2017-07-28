using System;
using System.Data;
using System.Data.SqlClient;

namespace DataExchangeService.Orders
{
    public class OrdersDataRecordAccess
    {
        public static void saveOrderCollection(OrderCollection orderCollection)
        {
            string statment = GetsaveOrderCollectionStatment(orderCollection);
            using (DataAccess dataAccess = new DataAccess())
            {
                ExecuteSaveOrderCollectionStatment(dataAccess, statment, orderCollection);
            }

        }

        private static void ExecuteSaveOrderCollectionStatment(DataAccess dataAccess, string statment, OrderCollection orderCollection)
        {
            try
            {


                foreach (Order order in orderCollection)
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.CommandText = statment;
                        command.CommandType = CommandType.Text;
                        command.Connection = dataAccess.Connection;
                        command.Parameters.Add("@orderID", order.OrderId);
                        command.Parameters.Add("@emailAddress", order.Email);
                        command.Parameters.Add("@asin", order.Item.ASIN);
                        command.Parameters.Add("@customerName", order.Name);
                        command.Parameters.Add("@amount", order.Amount);
                        command.Parameters.Add("@itemTitle", order.Item.Title);
                        command.Parameters.Add("@purchaseDate", order.PurchaseDate);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        private static string GetsaveOrderCollectionStatment(OrderCollection orderCollection)
        {
            string statment = "INSERT INTO Order_Master"
                + " (orderId, emailAddress, asin, customerName, amount, itemTitle, purchaseDate)"
                + " VALUES"
                + " (@orderID, @emailAddress, @asin, @customerName, @amount, @itemTitle, @purchaseDate)";
            return statment;
        }

        public static OrderCollection GetOrderCollection()
        {
            OrderCollection orderCollection = new OrderCollection();
            string statment = GetOrderCollectionStatment();
            using (DataAccess dataAccess = new DataAccess())
            {
                ExecuteGetOrderCollentionStatment(dataAccess, statment, orderCollection);
            }
            return orderCollection;

        }

        private static void ExecuteGetOrderCollentionStatment(DataAccess dataAccess, string statment, OrderCollection orderCollection)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = statment;
            command.CommandType = CommandType.Text;
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
                + " FROM Order_Master";
        }
    }
}
