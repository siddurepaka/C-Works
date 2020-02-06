using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate2
{
   // public delegate double calAreaPointer(double x);
    class Program
    {
        
        static void Main(string[] args)
        {
            //calAreaPointer cptr = new calAreaPointer(calArea);
            //double area = cptr(12);
            //Console.WriteLine(area);
            //Console.ReadLine();
            
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area1 = f1(15);
            Console.WriteLine(area1);
            Action<string> act =( a=> Console.WriteLine(a));
            act("Welcome");
            Predicate<string> pt = (y => y.Length > 3);
            int[] array = new int[] { 1, 3, 4, 5 };
            List<string> names = new List<string>();
            names.Add("Ram");
            names.Add("Ravi");
            names.Add("Sai");
            int a1= array.Count( x => x > 4);
            Console.WriteLine(a1
                );
            List<string> sn = names.FindAll(y => y.Contains('y'));
            foreach(string s in sn)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
      //  public static double calArea(double r)
        
          //  return 3.14 * r * r;

        
    }
}
