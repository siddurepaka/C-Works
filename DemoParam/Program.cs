using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            c1.Add(11, 22, 33, 44);
            Console.ReadLine();
        }
    }
}
