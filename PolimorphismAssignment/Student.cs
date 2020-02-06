using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismAssignment
{
    class Student
    {
        protected int stuId;
        protected string stuName;
        protected double examfee;
        public void displayDetails()
        {

        }
        public void payfee()
        {

        }
        class DayScholar : Student
        {
            protected double transportfee;
            public DayScholar(double transfee)
            {
                this.transportfee = transfee;
            }
        }
        class Hosteller:Student
            {
            protected double hostelfee;
            public Hosteller(double hstlfee)
            {
                this.
            }

        }

    }
}
