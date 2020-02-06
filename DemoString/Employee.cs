using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Employee
    {
        int salary;
        string name;
        string empid;
        public Employee()
        {

        }
        public  Employee(string name,string empid,int salary)
        {
            
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public override string Tostring()
        {
            return this.salary + "/n" + this.name + "/n" + this.empid;
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empid == temp.empid && this.name == temp.name)
                return true;
            else
                return false;
        }
    }
}
