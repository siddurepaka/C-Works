using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
   abstract class A
    {
        public abstract void Display();
    }
    class B : A
    {
        public override void Display()
        {
            Console.WriteLine("Display Clss B DEtails:");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Display Clss C DEtails:");
        }
    }
}
