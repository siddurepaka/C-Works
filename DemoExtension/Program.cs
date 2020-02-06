using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtension
{
    static class StringHelper
    {
        public static string FirstCaseChange(this string name)
        {
            char[] input = name.ToCharArray();
            input[0] = Char.IsUpper(input[0]) ? Char.ToLower(input[0]) : Char.ToUpper(input[0]);
            return new String(input);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Welcome:";
            Console.WriteLine(name.FirstCaseChange());
            Console.ReadLine();

        }
    }
}
