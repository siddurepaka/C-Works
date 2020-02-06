using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery();
            Console.WriteLine("Menu\n 1.Player details of the delivery\n 2.Run details of the delivery");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {

                Console.WriteLine("Enter the bowler name:");
                string bowlername = Console.ReadLine();
                Console.WriteLine("Enter the batsman name:");
                string batsmanname = Console.ReadLine();
                d.DisplayDeliveryDetails(bowlername, batsmanname);
            }
            else if (i == 2)
            {
                Console.WriteLine("Enter the Runs:");
                int runs = int.Parse(Console.ReadLine());
                d.DisplayDeliveryDetails(runs);

            }
            else
            {
                Console.WriteLine("INvalid");
            }
            

            Console.WriteLine();
            
        }
    }
}
