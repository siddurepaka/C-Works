using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProgram
{
    class Program
    {
        public static void Hello()
        {
            Console.WriteLine("Welcome to the world of c#");
        }
        public static void Welcome()
        {
            Console.WriteLine("Enter Username");
            string s = (Console.ReadLine());
            Console.WriteLine("HI!" + s + "\n Welcome to the world of C#");
        }
        public static void BetweenNos()
        {
            int k;
            Console.WriteLine("Enter the FirstNum:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the SecNum:");
            int j = int.Parse(Console.ReadLine());
            for (k = i; k < j; k++) 
            {
                Console.Write(k + "\t");
            }
            
        }
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a Num:");
            int i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            { 
                Console.WriteLine("Odd");
            }
        }
       
        public static void Temperature()
        {
            Console.WriteLine(" Enter the temperature in Fahrenheit:");
            double f = double.Parse(Console.ReadLine());
            double c = f - 32;
            double d = c * 5 / 9;
            Console.WriteLine("Temperature in Celsius" + d);

        }
        public static void Squares()
        {
            int i;
            for(i=0;i<=25;i++)
            {
                Console.WriteLine(i *i + "\t");
            }
            
        } 
        public static void Multiplication()
        {
            Console.WriteLine("Enter a No:");
            int i = int.Parse(Console.ReadLine());
            int j, k;
            for(j=1;j<=20;j++)
            {
                k = i * j;
                Console.WriteLine(i + "*" + j + "=" + k);
            }
        }
  public static void fibonacci(int n)
        {
            int a = 0; int b = 1; int c;
            for(int i =0 ;i<=n; i++)
            {
                if (i <= 1)
                    c = i;
                else
                {
                    c = a + b;
                    a = b;
                    b = c;

                }
                Console.WriteLine(c + "\t");
            }
        }
        public static void Divisible()
        {
            for(int i=200;i<=300;i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i + "\t");
            }
        }
        public static void factorial(int k)
        {
            
            int i = 1;
            int fact = 1;
            if (i <= k)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine(fact);
            }
        public static void TwoWords()
        {
            Console.WriteLine("enter first word");
            string s1 = (Console.ReadLine());
            Console.WriteLine("enter second word");
            string s2 = (Console.ReadLine());
            if (s1 == s2)
                Console.WriteLine("Words are same");
            else
                Console.WriteLine("Words are not same");

        }
        public static void largestofthreenum()
        {
            Console.WriteLine("enter three numbers:");
                int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine(a);
            else if (a > b && b > c)
                Console.WriteLine(b);
            else
                Console.WriteLine(c);
           
        }
        public static WordLength()
        {
            Console.
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome To The world of c#");
            // Hello();
            //Welcome();
            //EvenOrOdd();
            //BetweenNos();
            //Temperature();
            // Squares();
            //Multiplication();
            // fibonacci(40);
            // Divisible();
            // factorial(5);
            // TwoWords();
            largestofthreenum();
            Console.ReadKey();
        }
    }
}
