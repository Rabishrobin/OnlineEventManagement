using System;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineEventManagementSystem
{
    class DatabaseConnection
    {
        string DBConnection = ConfigurationManager.ConnectionStrings["EventManagement"].ConnectionString;
        SqlConnection connection = null;
        public DatabaseConnection()
        {
            EstablishConnection();
        }
        private void EstablishConnection()
        {
            connection = new SqlConnection(DBConnection);
        }
        private void RetriveData()
        {

        }
    }
}
