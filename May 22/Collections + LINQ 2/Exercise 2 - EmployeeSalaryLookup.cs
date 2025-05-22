class Program
{
    public static void Main(String[] args)
    {
        Dictionary<int,decimal> employees = new Dictionary<int,decimal>();
        employees.Add(101, 50000);
        employees.Add(102, 60000);
        employees.Add(103, 45000);
        employees.Add(104, 70000);
        employees.Add(105, 55000);

        Console.Write("Enter Employee ID: ");
        int empId= Convert.ToInt32(Console.ReadLine());

        if (employees.ContainsKey(empId))
        {
            Console.WriteLine($"Salary: {employees[empId]}");
        }
        else
        {
            Console.WriteLine("Employee ID not found.");
        }
    }
}

