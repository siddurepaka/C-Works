using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        string clgname;
        int rollno;
        string name;
        int cls;
        int sem;
        string branch;
        public Student(string clgname, int rollno, string name, int cls, int sem, string branch)
        {
            this.clgname = clgname;
            this.rollno = rollno;
            this.name = name;
            this.cls = cls;
            this.sem = sem;
            this.branch = branch;
        }
        public void DisplayResult()
        {
            Console.WriteLine("Enter the Marks of 5 subjects:");
            int[] marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0; int flag = 0;
            foreach (int i in marks)
            {
                if (i < 35)
                {
                    Console.WriteLine("Fail");
                    flag = 1;
                    break;
                }
                sum = sum + i;
            }
            if (flag == 0)
            {
                int avg = (sum / 5);
                if (avg >= 35 && avg <= 50)
                {
                    Console.WriteLine("Fail");
                }
                else
                    Console.WriteLine("Pass");
            }
            Console.ReadKey();
        }
        }
    }

