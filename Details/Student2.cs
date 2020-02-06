using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Details
{
    class Student2
    {
        interface Student
        {
            int sid  { get; set; }
            string name { get; set; }
            void showDetails();
        }
        class Residence:Student2
        {
            int sid; string name;
            int Student2.sid { get { return sid; } set { sid = value; } }
            string Student2.name { get { return name; } set { name} }
            
        }
    }
}
