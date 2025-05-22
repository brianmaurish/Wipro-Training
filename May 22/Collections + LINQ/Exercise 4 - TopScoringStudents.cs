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
        students.Add(new Student { Name = "Leo", Marks = 78 });

        var a = (from s in students
                orderby s.Marks descending
                select s).Take(3);

        Console.WriteLine("Top 3 scoring students: ");
        foreach(var b in a)
        {
            Console.WriteLine("Name: "+b.Name+" Marks: "+b.Marks);
        }
    }
}

