using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("A shape can be drawn:");
        }
        public void draw(int l)
        {
            this.length = l;
            Console.WriteLine("A square can be drawn:");
        }
        public void draw(int l, int w)
        {
            Console.WriteLine("A Rectangle can be drawn:");
        }
        public void draw(int l, int w, int b)
        {
            Console.WriteLine("A Box can be drawn:");
        }
    }
}
        