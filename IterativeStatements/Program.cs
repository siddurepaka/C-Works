using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterativeStatements
{
    class Program
    {
        public static void Greet(String name)
        {
            int flag = 1;
            while (flag <= 10)
            {
                Console.WriteLine("Hello" + name);
                flag++;
            }
        }
        public static void Displaywholenum(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t ");
                flag++;
            } while (flag <= i);
        }
        public static int ReturnFact(int k)
        {
            int fact = 1;
            int i = 1;
            for (; ; )
            {
                if (i <= k)
                {
                    fact = fact * i;
                    i++;
                }
                else
                    break;
            }
            return fact;
        }
        public static void DisplayEven(int no)
        {
            for(int j=1;j<=no;j++)
            { 
            if (j % 2 == 1)
                continue;
            Console.Write(j + "\t");
        }
    }
        public static string CheckVowel(char ch)
        { string result = null;
         switch(ch)
            {
                case 'a':
                    result = "Vowel";
                    break;
                case 'e':
                    result = "Vowel";
                    break;
                case 'i':
                    result = "Vowel";
                    break;
                case 'o':
                    result = "Vowel";
                    break;
                case 'u':
                    result = "Vowel";
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Greet("sachin");
            //Displaywholenum(100);
            // Console.WriteLine("enter  a no:");

            // Console.WriteLine(ReturnFact(5));
            //DisplayEven(100);    
          string Re=  CheckVowel('a');
            Console.WriteLine(Re);
        Console.ReadKey();
        }
    }
}
