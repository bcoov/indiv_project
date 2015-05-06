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
        private ConnectionFactory connector;

        // Constructor: Create a connection instance to the given database
        public Data(string dBase, string pword)
        {
            this.connector = ConnectionFactory.new_instance(dBase, pword);
        }

        public OleDbConnection connect_data()
        {
            return connector.create_connection();
        }

        public List<Employee> find_employees(OleDbConnection conn) {
            List<Employee> empList = new List<Employee>();
            // this isn't getting the whole Trainees table!
            string query = "select * from [TRAINEES]";

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee temp = new Employee();
                        temp.lastName = reader[0].ToString();
                        temp.firstName = reader[1].ToString();
                        temp.midInit = reader[2].ToString();
                        empList.Add(temp);
                    }
                    return empList;
                }
            }
        }

        public Employee find_an_employee(OleDbConnection conn, string fName, string lName)
        {
            Employee emply = new Employee();
            string query = "select * from [TRAINEES] where [FNAME]=? and [LNAME]=?";

            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", fName);
                cmd.Parameters.AddWithValue("?", lName);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        emply.lastName = reader[0].ToString();
                        emply.firstName = reader[1].ToString();
                        emply.midInit = reader[2].ToString();
                    }
                    return emply;
                }
            }
        }

        public List<String> get_tables(OleDbConnection conn) {
            List<String> tableNames = new List<String>();
            DataTable tables = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            foreach (DataRow row in tables.Rows) {
                tableNames.Add(row["TABLE_NAME"].ToString());
            }
            return tableNames;
        }
    }
}
