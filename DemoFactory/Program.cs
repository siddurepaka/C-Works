using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactory
{
    interface Ifactory



    {
        void manufacture(int cnt);

    }
    class Bike : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine(" bike Manufacture no:" + cnt);
        }
    }
    class Car : Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("car Manufacture no:" + cnt);
        }
    }
    abstract class VehicleFactory
    {
        public abstract Ifactory generatevehicle(string type);
    }
    class ConceretevehicleFactory : VehicleFactory
    {
        public override Ifactory generatevehicle(string type)
        {
            //throw new NotImplementedException();
            //Console.WriteLine()
            if (type == "Bike")
                return new Bike();
            else
                return new Car();
            // default:
            // Console.WriteLine("Factory cant produce");
            //break;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory obj = new ConceretevehicleFactory();
            Ifactory myVehicle = obj.generatevehicle("Bike");
            myVehicle.manufacture(10);
            myVehicle = obj.generatevehicle("car");
            myVehicle.manufacture(20);
            Console.ReadLine();
        }
    }

}