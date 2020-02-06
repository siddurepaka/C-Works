using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoParam
{
    class Calculator
    {
        public void Add(params int[] x)
        {
            int res = 0;
            foreach (int i in x) res += i;
            Console.WriteLine(res);
        }
    }
}
