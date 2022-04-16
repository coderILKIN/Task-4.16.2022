using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Mercedes", "‎EQS 580 4MATIC Sedan ", 270,"white",2020);
            Bus bus = new Bus(30,"BLACK",1991);

            Vehicle[] vehicles = { car, bus };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Showinfo();
            }

            
        }

       
    }
}
