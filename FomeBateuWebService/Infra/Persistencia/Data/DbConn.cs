using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace FomeBateuWebService.Data
{
    public class DbConn : IDbConn
    {
        public string server_name { get; set; }
        public string server_user { get; set; }
        public string server_pass { get; set; }
        public string server_dbname { get; set; }


        private SqlConnection sqlConnection;

        public SqlConnection Connection
        {
            get { return new SqlConnection(GetConnection()); }
        }


        private static string GetConnection()
        {
            foreach (ConnectionStringSettings conn in ConfigurationManager.ConnectionStrings)
            {
                if (conn.Name == "FomeBateuBD")
                    return conn.ConnectionString;
            }

            return "";
        }

    }
}
