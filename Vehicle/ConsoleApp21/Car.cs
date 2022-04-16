using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    class Car :Vehicle
    {

        private int _maxSpeed;

        public string Brand { get; set; }

        public string Model { get; set; }

        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value>0 && value<280)
                {
                    _maxSpeed = value;
                }
            }
        }

        public Car(string brand,string model,int maxspeed,string color,int year):base(color,year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxspeed;
        }

        public override void Showinfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model},Color:{Color},Year:{Year}, MaxSpped:{MaxSpeed}");
        }
    }
}
