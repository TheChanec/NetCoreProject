using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Core.Models.Configurations
{
    public class ConnectionConfig
    {
        private readonly IConfiguration config;

        public ConnectionConfig(IConfiguration config)
        {
            this.config = config;
        }

        public SqlConnection GetOpenConnection()
        {
            string cs = config["Data:DefaultConnection:ConnectionString"];
            SqlConnection connection = new SqlConnection(cs);
            connection.Open();
            return connection;
        }
    }
}
