using System;
using System.Data.SqlClient;

namespace DataExchangeService
{
    public class DataAccess : IDisposable
    {

        private SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _dataReader;



        private const string _SERVERNAME = "ttekdbinstance.cg0ekurzxtsb.us-east-2.rds.amazonaws.com";
        private const string _DATABASENAME = "ttekamazondb";
        private const string _USERNAME = "xiegeyang";
        private const string _PASSWORD = "X199241gy";
        private string _connetionString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", _SERVERNAME, _DATABASENAME, _USERNAME, _PASSWORD);

        public SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(_connetionString);
                    _connection.Open();
                }
                return _connection;
            }
        }

        public DataAccess()
        {

            _connection = new SqlConnection(_connetionString);
            _connection.Open();
        }


        public void Dispose()
        {
            _connection.Close();
        }
    }
}
