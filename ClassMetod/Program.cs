using ClassMetod.Vehicle;
using System;

namespace ClassMetod
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car mercedes = new Car();
            mercedes.Year = 2012;
            mercedes.colour = "black";
            mercedes.Brand = "Mercedes";
            mercedes.Model = "Cls63amg";
            mercedes.FuelCapacity = 80;
            mercedes.FuelFor1km = 0.14;
            mercedes.CurrentFuel = 14;
            mercedes.ShowStatus();
            double fuel = Car.Drive(200, 0.14);
            Console.WriteLine(fuel);

            
           


        }
        
    }
}
