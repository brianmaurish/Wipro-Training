class Employee
{
    public int EmployeeID {  get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name,decimal salary)
    {
        EmployeeID = id;
        Name = name;
        Salary = salary;
    }
}
class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee(101,"Brian",75000),
            new Employee(102,"Tim",60000),
            new Employee(103,"John",25000),
            new Employee(104,"Paul",45000),
            new Employee(105,"Rahul",72000)
        };

        //Find employee with highest salary
        Employee highestPaid = employees.OrderByDescending(e => e.Salary).First();
        Console.WriteLine("Highest paid employee: "+ highestPaid.Name+" Salary: "+ highestPaid.Salary);
        Console.WriteLine();

        //Store employeeID and Name in dictionary
        Dictionary<int,string> employeeDirectory = new Dictionary<int,string>();
        foreach (Employee employee in employees)
        {
            employeeDirectory[employee.EmployeeID] = employee.Name;
        }

        //Display dictionary contents
        Console.WriteLine("Employee Directory: ");
        foreach (var employee in employeeDirectory)
        {
            Console.WriteLine("ID: " + employee.Key + " Name: " + employee.Value);
        }
        Console.WriteLine();

        //search for employee by ID
        Console.WriteLine("Enter emnoloyee ID to search: ");
        int searchID = Convert.ToInt32(Console.ReadLine());
        if(employeeDirectory.ContainsKey(searchID))
        {
            Console.WriteLine("Employee Found: "+employeeDirectory[searchID]);
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
}