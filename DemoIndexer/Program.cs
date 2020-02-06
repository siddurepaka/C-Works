using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Car
    {
        string[] name = new string[4];
        public int year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public string this[int x]
        {
            get
            {
                return name[x];

            }
            set
            {
                name[x] = value;
            }
        }
        public void display()
        {
            foreach (string val in name)
                Console.WriteLine(val);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

