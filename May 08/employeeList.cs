class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
}


class Program
{
    public static void Main(string[] args)
    {

        List<Employee> employee = new List<Employee>
        {
            new Employee { ID=1,Name="Maxi"},
            new Employee { ID=2,Name="Tim"}
        };

        //Add elements into list
        employee.Add(new Employee { ID = 3, Name = "Choplin" });
        employee.Add(new Employee { ID = 4, Name = "Mathew" });
        employee.Add(new Employee { ID = 3, Name = "Tom" });

        //Remove an element by name
        employee.RemoveAll(e => e.Name == "Tom");

        //Check if an element exists or not
        bool found=employee.Exists(e => e.Name == "Mathew");
        if (found)
        {
            Console.WriteLine("Mathew is present");
        }
        else
        {
            Console.WriteLine("Mathew is not present");
        }

        //Count the number of employees
        int count=employee.Count();
        Console.WriteLine("The no of employees: " + count);

        //Print the elements in list
        foreach (var emp in employee)
        {
            Console.WriteLine($"ID: {emp.ID}, Name:{emp.Name}");
        }
    }
}

