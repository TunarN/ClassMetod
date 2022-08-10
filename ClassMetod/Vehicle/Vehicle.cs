using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetod.Vehicle
{
    public class Vehicle
    {
        public string colour;
        public  int Year;
        public Vehicle()
        {     

        }
        public Vehicle(string colour)
        {
            this.colour = colour;
        }
        public Vehicle(int Year)
        {
            this.Year = Year;
        }
        public Vehicle(int Year, string colour)
        {

        }
    }
}
