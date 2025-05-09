using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Calculator
    {
        //Addition 
        public int Add(int a,int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }

        //Multiplication 
        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

        //Subtraction
        public int Sub(int a,int b)
        {
            return a - b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public int Sub(int a, int b, int c)  
        {
            return a - b - c;
        }
    }
}

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Calculator obj = new Calculator();

            Console.WriteLine("Addition of 3 and 2 is: " + obj.Add(3, 2));
            Console.WriteLine("Addition of 3,5 and 2 is: " + obj.Add(3, 5, 2));
            Console.WriteLine("Addition of 3.2  and 2.5 is: " + obj.Add(3.2, 2.5));
            Console.WriteLine();

            Console.WriteLine("Multiplication of 3 and 2 is:  " + obj.Mul(3, 2));
            Console.WriteLine("Multiplication of 3,5 and 2 is: " + obj.Mul(8, 2, 5));
            Console.WriteLine("Multiplication of 3.2  and 2.5 is: " + obj.Mul(3.2, 2.5));
            Console.WriteLine();

            Console.WriteLine("Subtraction of 3 and 2 is:  "+ obj.Sub(3,2));
            Console.WriteLine("Subtraction of 3,5 and 2 is: " + obj.Sub(8, 2, 5));
            Console.WriteLine("Subtraction of 3.2  and 2.5 is: " + obj.Sub(3.2, 2.5));

        }
    }
}


