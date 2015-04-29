using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    internal abstract class Data<T>
    {
        protected ConnectionFactory conn_fact;

        // Constructor
        protected Data(string conn_name, string conn_pass)
        {
            conn_fact = ConnectionFactory.new_instance(conn_name, conn_pass);
            return;
        }

        protected T get_result(Func<IDataReader, T> extract_func, IDataReader reader)
        {
            using (reader)
            {
                if (!reader.Read())
                {
                    return default(T);
                }
                return extract_func(reader);
            }
        }

        protected T[] get_results(Func<IDataReader, T> extract_func, IDataReader reader)
        {
            using (reader)
            {
                List<T> results = new List<T>();
                while (reader.Read())
                {
                    results.Add(extract_func(reader));
                }
                return results.ToArray();
            }
        }

        protected NT extract_scalar<NT>(IDataReader reader)
        {
            using (reader)
            {
                if (reader.Read())
                {
                    return (NT)reader.GetValue(0);
                }
                else
                {
                    return default(NT);
                }
            }
        }
    }
}
