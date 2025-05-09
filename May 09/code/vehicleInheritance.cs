using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
     class Vehicle
    {
        public string Make;
        public string Model;

        public void DisplayVehicle()
        {
            Console.WriteLine("Make: " + Make);
            Console.WriteLine("Name: " + Model);
        }
    }
    class Car : Vehicle
    {
        public string FuelType;

        public void DisplayCar()
        {
            Console.WriteLine("FuelType: " + FuelType);
        }
    }
}


namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Vehicle vehicle=new Vehicle();
            Car car1 = new Car();

            vehicle.Make = "2021";
            vehicle.Model = " Nissan";
            car1.FuelType = "Petrol";

            vehicle.DisplayVehicle();
            car1.DisplayCar();


        }
    }
}


