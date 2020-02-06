using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDetails
{
    class Delivery
    {
        public void DisplayDeliveryDetails()
        {

        }
        public void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Bowler name is:" + bowler + "Batsman name is:" + batsman);
            Console.ReadLine();

        }
        public void DisplayDeliveryDetails(int runs)
        {
            if(runs==6||runs==4)
            {
                Console.WriteLine("IT IS:" + runs);
            }
               else
            {
                Console.WriteLine("RUNS:" + runs);
                
            }
        }
    }
}
