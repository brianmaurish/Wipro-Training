class Student
{
    public string Name;
    public int Marks;
}

class Program
{
    public static void Main(String[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student { Name = "Jim", Marks = 85 });
        students.Add(new Student { Name = "Jerry", Marks = 95 });
        students.Add(new Student { Name = "Bob", Marks = 73 });
        students.Add(new Student { Name = "Alice", Marks = 65 });
        students.Add(new Student { Name = "Richard", Marks = 82 });

        double averageMarks = (from s in students
                               select s.Marks).Average();
        Console.WriteLine($"Average Marks: {averageMarks}");

        int aboveAverageCount = (from s in students
                                 where s.Marks > averageMarks
                                 select s).Count();

        Console.WriteLine("The number of students scored above average: " + aboveAverageCount);
    }
}

