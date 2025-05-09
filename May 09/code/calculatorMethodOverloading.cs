using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Calculator
    {
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

        }
    }
}


