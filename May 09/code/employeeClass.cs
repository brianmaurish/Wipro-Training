using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Employee
    {
        public int EmployeeID;
        public string Name;
        public int Salary;

        public void PrintDetails()
        {
            Console.WriteLine("EmployeeID: " + EmployeeID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }

        public void UpdateSalary(int value)
        {
            Salary = Salary + value;
        }

        public void AnnualSalary()
        {
            Console.WriteLine("The annual salary is: "+ Salary * 12);
        }
    }
}

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {

            Employee employee1 = new Employee();

            employee1.EmployeeID = 1;
            employee1.Name = "Ancy";
            employee1.Salary = 25000;

            employee1.PrintDetails();

            employee1.UpdateSalary(2000);

            employee1.AnnualSalary();

            employee1.PrintDetails();

        }
    }
}
