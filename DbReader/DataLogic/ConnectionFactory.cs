using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    /**
     * Database tutorial: http://forum.codecall.net/topic/62182-c-and-databases-part-3-connection-objects/
     */
    internal class ConnectionFactory    // Internal: Only accessible within this assembly
    {
        private string preamble = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=";
        private string validator = "; Jet OLEDB:Database Password=";
        private string connect_str;

        private ConnectionFactory(string dbConn, string passWord)
        {
            this.connect_str = preamble + dbConn + validator + passWord;
            return;
        }

        // Constructor: Creates a new connection instance from the given string.
        internal static ConnectionFactory new_instance(string connect, string pass)
        {
            try
            {
                return new ConnectionFactory(connect, pass);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal OleDbConnection create_connection()
        {
            try
            {
                return new OleDbConnection(connect_str);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
