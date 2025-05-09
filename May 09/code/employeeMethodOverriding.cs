using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Employee
    {
       public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is supervising");
        }
    }
}

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.Work(); //calls base method

            Manager mgr = new Manager();
            mgr.Work(); //calls overridden method

            Employee polyEmp = new Manager();
            polyEmp.Work(); //calls overridden method

        }
    }
}


