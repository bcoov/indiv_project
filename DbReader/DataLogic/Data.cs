using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    public class Data
    {
        private ConnectionFactory conn_fact;

        // Constructor
        public Data(string conn_name, string conn_pass)
        {
            conn_fact = ConnectionFactory.new_instance(conn_name, conn_pass);
            return;
        }

        public Employee find_employees(string lastName, string firstName)
        {
            string query = "Select * from Trainees where Lname = ? and Fname = ?";

            using (OleDbConnection connect = conn_fact.create_connection())
            {
                try
                {
                    connect.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("first", lastName);
                        cmd.Parameters.AddWithValue("second", firstName);

                        Employee result = null;
                        using (OleDbDataReader read = cmd.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                result = new Employee();
                                result.firstName = (string)read["fname"];
                                result.lastName = (string)read["lname"];
                            }
                        }

                        return result;
                    }
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        
    }
}
