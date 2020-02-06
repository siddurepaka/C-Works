using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClass
{
    class Student
    {
        int Roll;
        string Name;
        string Bnch;
        double Mks;
        public void RollNumber()
        {
            Console.WriteLine("enter the RollNum:");
            this.Roll = int.Parse(Console.ReadLine());
        }
        public  void Names()
        {
            Console.WriteLine("enter Name:");
            this. Name = Console.ReadLine();
        }
        public void Branch()
        {
            Console.WriteLine("enter the branch of Student:");
            this. Bnch = Console.ReadLine();
        }
        public void  Marks()
        {
            Console.WriteLine("Enter the marks of a Student:");
            this. Mks = int.Parse(Console.ReadLine());
            Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine(this.Roll+"/n" + this.Name + this.Bnch + this.Mks);  
            Console.ReadLine();
        }
     


    }
}
