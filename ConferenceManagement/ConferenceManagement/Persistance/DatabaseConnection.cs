using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ConferenceManagement.Persistance
{
   /// <summary>
   /// Singleton class for creating a databse connection.
   /// </summary>
    public static class DatabaseConnection
    {
       
        private static IDbConnection instance = null;
        /// <summary>
        /// Gets the connection to the database.
        /// </summary>
        /// <returns>The connection to the data source</returns>
        public static IDbConnection getConnection()
        {
            if (instance == null || instance.State == System.Data.ConnectionState.Closed)
            {
                instance = getNewConnection();
                instance.Open();
            }
            return instance;
        }

        /// <summary>
        /// Creats a new connection to the data source.
        /// </summary>
        /// <returns>The connection to the data source</returns>
        private static IDbConnection getNewConnection()
        {
            string con = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            return new SqlConnection(con);
        }
    }
}
