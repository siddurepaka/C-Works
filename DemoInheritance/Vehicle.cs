using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Vehicle
    {
        string color;
        public Vehicle()
        {
            this.color = "white";
            Console.WriteLine("Constuctor from Vehicle:");
        }
        public void Start()
        {
            Console.WriteLine("VEhicle started:");
        }
        public void stop()
        {
            Console.WriteLine("Vehicle Stopped:");
        }
    }
    class Bus : Vehicle
    {
       protected int seating;
       protected int speed;
        public Bus()
        {
            this.seating = 100;
            this.speed = 150;
            Console.WriteLine("Constructor from Bus");
        }

        public void Run()
        {
            Console.WriteLine("Bus is running at speed" + " " + this.speed + " " + "with passengers" + this.seating);
        }
    }
    class Car : Vehicle
    {
        int speed;
        string type;
        public Car()
        {
            this.speed = 100;
            this.type = "premium";
            Console.WriteLine("Constructor from Car");
        }
        public void Drive()
        {
            Console.WriteLine("car is running at speed" + " " + this.speed + " " + "with type" + this.type);
        }
    }
}

