using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Employee
    {
        int empid;
        string ename;
        string empDesignation;
        public int eid { get; set; }
        public Employee()
        {

        }
        public Employee(int eid, string ename, string empDesignation)
        {
            this.eid = eid;
            this.ename = ename;
            this.empDesignation = empDesignation;

        }
        public override string ToString()
        {
            return this.empid + " " + this.ename + " " + this.empDesignation;
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<Employee> elist = new List<Employee>();
                Console.WriteLine("Menu\n 1.Insert EmployeeDEtails\n 2.Display all employee Details\n 3.update employeeDetails basef on Id\n 4.Delete a specific employee whos id is given");
                Console.WriteLine("Enter ur choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter No.of Employees:");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Enter the empid");
                            int empid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the ename");
                            string ename = Console.ReadLine();
                            Console.WriteLine("Enter the empDesignation");
                            string empDesignation = Console.ReadLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Employee Details:");
                        foreach (Employee e in elist)
                            Console.WriteLine(e.ToString());
                        break;
                        Console.ReadLine(); 

                }

            }
        }
    }
}
