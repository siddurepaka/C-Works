using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethod
{
    class Calculator
    {
        int Val1;
        int Val2;
        public int val1 { get => val1; set => val1 = value; }
        public int val2 { get => val2; set => val2 = value; }
        public Calculator()
        {

        }
        public Calculator(int val1,int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public void Add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);

        }
      //  public void Swap(ref int num1,ref int num2)
        //{
        //    int temp = num1;
          //  num1 = num2;
            //num2 = temp;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
        //}
        public void Subtract(int num1,int num2,out int res)
        {
            res = num1 - num2;
        }
    }






}
