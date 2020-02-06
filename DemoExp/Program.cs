using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n / 0);

                try
                {
                    int[] a = new int[] { 1, 2, 3 };
                    Console.WriteLine(a[3]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
                }


              /*  catch (Exception e)
                {
                    Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
                }*/

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}