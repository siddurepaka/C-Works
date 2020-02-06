using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Shape s = new Shape();

             s.draw();
             s.draw(10);
             s.draw(10,20); 
             s.draw(10,20,30);
             Console.ReadLine();*/
            A obj1 ;
            obj1 = new B();
            obj1.Display();

            Console.ReadLine();
        }
    }
}
