using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    internal class Tester : Data
    {
        private ConnectionFactory test_fact;

        internal Tester(string connection)
        {
            // "null" is a placeholder here. This creates a connection, so need to find a way to
            // pass the selectedFilePath here or something similar
            test_fact = ConnectionFactory.new_instance(connection);
            return;
        }

        internal bool conn_works()
        {
            bool success = false;

            try
            {
                using (OleDbConnection connecter = test_fact.create_connection())
                {
                    connecter.Open();
                    success = true;
                }
            }
            catch (Exception)
            {
                success = false;
            }
            return success;
        }
    }
}
