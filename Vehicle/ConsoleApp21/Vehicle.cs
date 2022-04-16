using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    abstract class Vehicle
    {
        public string Color { get; set; }

        public int Year { get; set; }

        public Vehicle(string color,int year)
        {
            Year = year;
            Color = color;
        }

        public abstract void Showinfo();
    }
}
