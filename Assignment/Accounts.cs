using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Accounts
    {
        int accno;
        string name;
        string acctype;
        string transtype;
        int amount;
        double balance;
        public Accounts(int accno, string name, string acctype)
        {
            this.accno = accno;
            this.name = name;
            this.acctype = acctype;
        }
            public void Deposit(double amt)
        {
            this.transtype = "D";
            this.balance += amt;
        }
        
        public void Debit(double amt)
        {
            this.transtype = "W";
            this.balance -= amt;
        }

        
             

        }
      
    }

