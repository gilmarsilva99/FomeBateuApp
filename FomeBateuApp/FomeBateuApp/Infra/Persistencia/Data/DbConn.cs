using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace FomeBateuWebService.Data
{
    public class DbConn : IDbConn
    {
        public string server_name { get; set; }
        public string server_user { get; set; }
        public string server_pass { get; set; }
        public string server_dbname { get; set; }


        private SqlConnection sqlConnection;

        public string GetConnectionString()
        {
            if (string.IsNullOrEmpty(server_dbname) || string.IsNullOrEmpty(server_name) ||
                string.IsNullOrEmpty(server_pass) || string.IsNullOrEmpty(server_user))
            {
                return "error";
            }

            string s = $"Data Source = {server_dbname},1433; Initial Catalog = {server_dbname}; User Id = {server_user}; Password = {server_pass}";
            return s;
        }

        public SqlConnection Connection
        {
            get { return new SqlConnection(GetConnectionString()); }
        }

    }
}
