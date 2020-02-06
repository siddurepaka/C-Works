using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEXception
{
    class employee
    {
        string name;
        string id;
        int salary;
        public employee(string name,string id,int salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public int Salary { get; set; }
    }
    public class salaryException : Exception
        {
        public salaryException(string s) : base(s)
        { }
           }
    
}
