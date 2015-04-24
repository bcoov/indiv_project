using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    /**
     * This series of classes doesn't really do anything yet. It's largely a framework modeled
     * from the tutorial referenced in the Data class. Should allow the groundwork for Db
     * operations however.
     */
    internal class Tester : Data<Employee>
    {
        // Constructor
        internal Tester()
            : base(ConfigurationManager.AppSettings["db.connections.default"])
        {
            return;
        }

        // Build an Employee object from the database
        private Employee findEmployee(IDataReader read)
        {
            Employee emp = new Employee();
            emp.id = read.GetInt32(0);
            emp.firstName = read.GetString(1);
            emp.lastName = read.GetString(2);
            if (read.IsDBNull(3))
            {
                emp.eMail = null;
            }
            else
            {
                emp.eMail = read.GetString(3);
            }
            return emp;
        }

        // Query and return all Employees within an array (id, first/last name)
        internal Employee[] findAllEmployees()
        {
            string sqlQuery = "select id, firstName, lastName, email from ***";

            using (OleDbConnection conn = conn_fact.create_connection())
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(sqlQuery, conn))
                {
                    using (IDataReader reader = command.ExecuteReader())
                    {
                        return base.get_results(findEmployee, reader);
                    }
                }
            }
        }
        /*private ConnectionFactory test_fact;

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
        }*/
    }
}
