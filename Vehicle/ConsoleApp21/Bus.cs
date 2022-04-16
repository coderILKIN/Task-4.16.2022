using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    class Bus : Vehicle
    {
        private byte _pasengerCount;


        public byte PasengerCount { 
            get 
            {
                return _pasengerCount;
            }
            set
            {
                if (value>0 && value<50)
                {
                    _pasengerCount = value;
                }
            }
        }


        public Bus(byte passengercount,string color,int year):base(color,year)
        {
            PasengerCount = passengercount;
        }


        public override void Showinfo()
        {
            Console.WriteLine($"PasengerCount: {PasengerCount},Color: {Color},Year: {Year}");  
        }
    }
}
