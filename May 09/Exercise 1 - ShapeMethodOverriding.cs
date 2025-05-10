using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing");
        }
        
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
}

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Shape obj = new Circle(); //Shape reference holding circle object
            obj.Draw(); //calling deriver class

            Circle obj2 = new Circle();
            obj2.Draw(); //calling derived class

        }
    }
}


