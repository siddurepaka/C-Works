using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Parent obj1 = new Parent();
             Child obj2 = new Child();
             GrandChild obj3 = new GrandChild();
             obj1.getvalues(12,"C#");
             obj1.Display();
             obj2.getvalues(20, "ASP.NET");
             obj2.Display();
             obj3.getvalues(10, "ASP.Core");
             obj3.Display();
             obj2.Calculator(20);
             obj3.multiply(10);

             Console.ReadLine();*/
            Vehicle v1 = new Vehicle();
            Car c1 = new Car();
            Bus b1 = new Bus();
            v1.Start();
            v1.stop();
            b1.Start();
            b1.Run();
            c1.stop();
            c1.Start();
            c1.Drive();
            c1.stop();

            Console.ReadLine();
        }
    }
}
