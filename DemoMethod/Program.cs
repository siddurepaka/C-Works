using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int result = cal.Add(x, y);
            Console.WriteLine(result);
            cal.Subtract(x, y, out int sub);
            Console.WriteLine(result);
            cal.Add(x, y);
            cal.Swap(ref x, ref y);
            Console.WriteLine(x + " " + y);
            Console.ReadLine();
        }
    }
}
