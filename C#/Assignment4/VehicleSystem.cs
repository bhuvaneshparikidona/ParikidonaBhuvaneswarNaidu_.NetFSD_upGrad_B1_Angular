using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{

    class Vehicle
    {
        public string VehicleNumber { get; set; }
        public string Brand { get; set; }

        public Vehicle(string number, string brand)
        {
            VehicleNumber = number;
            Brand = brand;
        }

        public void StartVehicle()
        {
            Console.WriteLine("Vehicle started");
        }
    }

    class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(string number, string brand, string fuelType)
            : base(number, brand)
        {
            FuelType = fuelType;
        }
    }

    sealed class ElectricCar : Car
    {
        public ElectricCar(string number, string brand, string fuelType)
            : base(number, brand, fuelType)
        {
        }
    }

   
    // class Tesla : ElectricCar { }  // This will give compilation error

    class VehicleSystem
    {
        static void Main()
        {
            ElectricCar car = new ElectricCar("AP02BL2028", "Tesla", "Electric");
            car.StartVehicle();
            Console.WriteLine(car.VehicleNumber + " " + car.Brand + " " + car.FuelType);
        }
    }
}
