using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string str = "Welcome";
              Console.WriteLine(str.Length + " " + str.Replace("w", "a") + " " + str.ToLower());
              Console.WriteLine(str.Contains("1c"));
              Console.WriteLine(string.Compare("hello", "Hello"));
              string str1 = "WELCOME";
              Console.WriteLine(str.Equals(str1));
              Console.ReadLine();*/
            Employee[] eArray = new Employee[3] { new Employee("arun", " 21", 20000), new Employee("Ravi", "21", 20000), new Employee("Ram", "21", 20000) };

            foreach (Employee e in eArray)
            {
                Console.WriteLine(e.Tostring());
            }
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("arun", " 21", 20000));
            elist.Add(new Employee("Ravi", " 21", 20000));
            elist.Add(new Employee("Ram", " 21", 20000));
            foreach (Employee e in elist)
            {
                Console.WriteLine(e.Tostring());
            }


        }
    }
}

    