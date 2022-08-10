using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetod.Vehicle
{
     public class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public int FuelCapacity;
        public double FuelFor1km;
        public int CurrentFuel;
        public Car()
        {

        }
        public Car(int Year,string colour, string Brand, string Model, int FuelCapacity, double FuelFor1km , int CurrentFuel):base(Year,colour)
        {
            
        }
        public void ShowStatus()
        {
            Console.WriteLine($"{Year} {colour} {Brand} {Model} {FuelCapacity} {FuelFor1km} {CurrentFuel}");
        }

        double fuel = 80;
        double distance = 200;
        double fuelfor1km = 0.14;
        public static double Drive(double distance, double fuelfor1km)
        {
            double fuel = 80;
            if (fuel>0)
            {
                fuel -= distance * fuelfor1km;
                             
            }
            return fuel;
           
        }

    }
}
