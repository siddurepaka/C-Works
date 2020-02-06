using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    class Program
    {
        public delegate void delegatePointer();
        public delegate double calAreaPointer(double r);
            static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Program p = new Program();
            delegatePointer mydelegate = p.print;
            mydelegate();
            calAreaPointer cpt = Calculate.CalArea;
            double area = cpt(20);
            Console.WriteLine(area);
            Console.ReadLine();
              
        }
        public  void print()
        {
            Console.WriteLine("Welcome to Delegate");
        }
    }
}
