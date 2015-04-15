using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    /**
     * Database tutorial: http://forum.codecall.net/topic/62182-c-and-databases-part-3-connection-objects/
     * **Is this a persistence layer style setup?
     */
    internal class ConnectionFactory    // Internal: Only accessible within this assembly
    {
        private string connection_str;

        private ConnectionFactory(string conn_str)
        {
            connection_str = conn_str;
            return;
        }

        // Constructor: Creates a new connection instance from the given string
        // using the configuration file. Still trying to figure this part out.
        internal static ConnectionFactory new_instance(string connection_name)
        {
            try
            {
                return new ConnectionFactory(ConfigurationManager.ConnectionStrings[connection_name].ConnectionString);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal SqlConnection create_connection()
        {
            try
            {
                return new SqlConnection(connection_str);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
