using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the college Name:");
            string clgname = Console.ReadLine();
            Console.WriteLine("Enter the student RollNo:");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the class:");
            int cls = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Semester:");
            int sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Branch");
            string branch = Console.ReadLine();
            Student s = new Student(clgname,rollno,name,cls,sem,branch);
            s.DisplayResult();


          
        }
    }
}
