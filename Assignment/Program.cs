
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Account Num:");
            int accno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Customer Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Account Type:");
            string acctype = Console.ReadLine();
            Accounts acc1 = new Accounts(accno, name, acctype);
            Console.WriteLine("Enter the Transaction Type: \n D for Deposite \n W for Withdraw");

            
            char transtype = char.Parse(Console.ReadLine());

            if (transtype == 'd' || transtype == 'D')
            {
                Console.WriteLine("Enter amount:");
                double amt = double.Parse(Console.ReadLine());
              acc1.Deposit(amt);

            }
            else if (transtype == 'w' || transtype == 'W') 
            {
                Console.WriteLine("Enter amount");
                double amt = double.Parse(Console.ReadLine());
               acc1.Debit(amt);
            }
           // Console.WriteLine("Enter the Amount:");
           //
            
            int Amount = int.Parse(Console.ReadLine());
            // Console.WriteLine("Balance:");
            //int Bal = int.Parse(Console.ReadLine());
        }
    }
}
