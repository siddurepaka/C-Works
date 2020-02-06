using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.RollNumber();
            s.Names();
            s.Branch();
            s.Marks();
            s.Display();
            Console.ReadLine();
        }
    }
}
