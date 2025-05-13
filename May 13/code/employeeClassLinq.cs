using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public int Age { get; set; }

}
class Program
{
    static void Main(string[] args)
    {
        Employee[] EmployeeArray = {
            new Employee() { EmployeeID = 1, EmployeeName = "John", Age = 18 },
            new Employee() { EmployeeID = 2, EmployeeName = "Steve", Age = 21 },
            new Employee() { EmployeeID = 3, EmployeeName = "Bill", Age = 25 },
            new Employee() { EmployeeID = 4, EmployeeName = "Ram", Age = 20 },
            new Employee() { EmployeeID = 5, EmployeeName = "Ron", Age = 31 },
            new Employee() { EmployeeID = 6, EmployeeName = "Chris", Age = 17 },
            new Employee() { EmployeeID = 7, EmployeeName = "Rob", Age = 19 },
        };

        /*
        Employee[] Employees = new Employee[10];

        int i = 0;
        foreach (Employee employee in EmployeeArray)
        {
            if (employee.Age > 12 && employee.Age < 20)
            {
                Employees[i] = employee;
                Console.WriteLine(employee.EmployeeName);
                i++;
            }
        }
        */

        //Use LINQ to find teenager Employees
        Employee[] teenAgerEmployees = EmployeeArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();

        foreach(Employee emp in teenAgerEmployees)
        {
            Console.WriteLine(emp.EmployeeName);
        }

        //Use LINQ to find first employee whose name is Bill
        Employee bill = EmployeeArray.Where(s=>s.EmployeeName=="Bill").FirstOrDefault();

        if (bill != null)
        {
            Console.WriteLine("Found Bill: "+ bill.EmployeeName + ", Age: "+bill.Age);
        }

        //Use LINQ to find employee whose EmployeeID is 5
        Employee Employee5 = EmployeeArray.Where(s => s.EmployeeID == 5).FirstOrDefault();
        
        if(Employee5!=null)
        {
            Console.WriteLine("The employee ID 5: " + Employee5.EmployeeName);
        }
    }
}
