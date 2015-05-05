using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    public class Employee
    {
        public Employee()
        {

        }

        internal int id { get; set; }

        internal string firstName { get; set; }

        internal string lastName { get; set; }

        internal string midInit { get; set; }
    }
}
