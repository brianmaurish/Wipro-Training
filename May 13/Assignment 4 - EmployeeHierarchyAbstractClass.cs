using System.Security.Cryptography.X509Certificates;

abstract class Employee
{
    public abstract void CalculateSalary();
    public void ShowBasicInfo()
    {
        Console.WriteLine("Employee details");
    }

}
class FullTimneEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary: Basic + Allowance");
    }
}
class PartTimeEmployee : Employee
{
    public override void CalculateSalary()
    {
        Console.WriteLine("Salary: Hourely rate x Hours worked");
    }
}

class Program
{
    public static void Main()
    {
        Employee employee = new FullTimneEmployee();
        employee.ShowBasicInfo();
        employee.CalculateSalary();

        employee = new PartTimeEmployee();
        employee.ShowBasicInfo();
        employee.CalculateSalary();

    }
}