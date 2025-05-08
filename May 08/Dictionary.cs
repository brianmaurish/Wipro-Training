class Program
{
    public static void Main()
    {
        //Creating a Dictionary
        Dictionary<int,string> students = new Dictionary<int, string>();

        //Adding elements
        students.Add(101, "Alice");
        students.Add(102, "Bob");
        students.Add(103, "Charlie");

        //Accessing values using keys
        Console.WriteLine("Student with ID 102: " + students[102]);

        //Looping through the dictionary
        foreach (var student in students)
        {
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
    }
}
