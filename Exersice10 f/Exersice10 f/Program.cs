using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises10
{
    class Program
    {
        static void Main(string[] args)
        {

            VehicleData vehicleData = new VehicleData();
            Car cars = new Car();
            Bicycle bicycle= new Bicycle();

            vehicleData.PrintVehicle(cars);
            vehicleData.PrintVehicle(bicycle);




            Console.ReadKey();
        }
    }
}

