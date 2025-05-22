class Employee
{
    public string Name;
    public string Department;
}

class Program
{
    public static void Main(String[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee { Name = "John", Department = "HR" });
        employees.Add(new Employee { Name = "Bob", Department = "Finance" });
        employees.Add(new Employee { Name = "David", Department = "HR" });
        employees.Add(new Employee { Name = "Gokul", Department = "IT" });
        employees.Add(new Employee { Name = "Aditya", Department = "Finance" });
        employees.Add(new Employee { Name = "Ishan", Department = "IT" });

        var a = from e in employees
                group e by e.Department into g
                select g;

        foreach(var e in a)
        {
            Console.WriteLine("Employees in "+e.Key+" department: ");

            foreach(var g in e)
            {
                Console.WriteLine(g.Name);
            }
            Console.WriteLine();
        }
    }
}

