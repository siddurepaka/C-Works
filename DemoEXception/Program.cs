using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEXception
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<employee> elist = new List<employee>();
            elist.Add(new employee("Raj", "100", 10000));
            elist.Add(new employee("Raja", "120", 30000));
            elist.Add(new employee("Raju", "130", 60000));
            elist.Add(new employee("Raji", "160", 30000));
            List<employee> highpay = elist.FindAll(e => e.Salary > 12000);
            foreach (employee e1 in highpay)
                Console.WriteLine(e1.ToString());
            Console.ReadLine();

        }
    }
}
