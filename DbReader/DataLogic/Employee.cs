using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbReader.DataLogic
{
    internal class Employee
    {
        internal int id { get; set; }

        internal string firstName { get; set; }

        internal string lastName { get; set; }

        internal string eMail { get; set; }     // Database may not contain this, probably good to have in case
    }
}
