using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOops
{
    class Bike
    {
        string name;
        string color;
        public void StartEngine()
        {
            Console.WriteLine("Bike Started at:" + DateTime.Now);
        }
        public void FillGas(int litre)
        {
            Console.WriteLine("Gas Filled:" + litre + "litres");
        }
        public int Travel(int distance,int speed)
        {
            int time = (int)(distance / speed);
            Console.WriteLine("You will reach by" + time);
            return 0;

        }
    }
}
