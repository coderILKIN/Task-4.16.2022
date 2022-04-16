using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
        
            Console.WriteLine(program.Sum(21,22));
            Console.WriteLine(program.Minus(43,12,10));
            Console.WriteLine(program.Multiply(10,5,2));
            Console.WriteLine(program.Divided(21,9));
            
           
        }

        public int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Sum(int a, int b, int c)
        {
            int sum = a + b+c;
            return sum;
        }


        public int Sum(int a, int b,int c,int d)
        {
            int sum = a + b + c + d;
            return sum;
        }

        public int Minus(int a, int b)
        {
            int minus = a - b;
            return minus;
        }


        public int Minus(int a, int b,int c)
        {
            int minus = a - b-c;
            return minus;
        }

        public int Minus(int a, int b,int c,int d)
        {
            int minus = a - b - c - d;
            return minus;
        }

        public int Multiply(int a, int b)
        {
            int multiply = a * b;
            return multiply;
        }

        public int Multiply(int a, int b,int c)
        {
            int multiply = a * b *c;
            return multiply;
        }


        public int Multiply(int a, int b, int c, int d)
        {
            int multiply = a * b * c *d;
            return multiply;
        }


        public double Divided(double a, double b)
        {
            double divided = a / b;
            return divided;
        }

        public double Divided(double a, double b, double c)
        {
            double divided = a / b / c;
            return divided;
        }

        public double Divided(double a, double b, double c, double d)
        {
            double divided = a / b / c / d;
            return divided;
        }



       

    }

}
