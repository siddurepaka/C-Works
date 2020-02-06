using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class Program
    {
        //public static string EvenorOdd(int i)
         //   public static int Max(int i, int j, int k)
           public static string Result(double m1, double m2, double m3, double m4, double m5)
         {
            double avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if (avg >= 70)
                return "distinction";
            else if (avg >= 60 && avg < 70)
                return "FirstClass";
            else if (avg >= 50 && avg < 50)
                return "second class";
            else
                return "Fail";
        }
 

    static void Main(String[] args) {
        Console.WriteLine(Result(55.5, 56.6, 67, 88, 99));
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double m3 = Convert.ToDouble(Console.ReadLine());

            double m4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Result(m1,m2,m3,m4));


            Console.ReadKey();
    }
}
          

}