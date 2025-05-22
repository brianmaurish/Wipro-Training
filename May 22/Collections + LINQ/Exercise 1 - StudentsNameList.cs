class Program
{
    public static void Main(String[] args)
    {
        List<string> students = new List<string>();
        students.Add("George");
        students.Add("Helen");
        students.Add("Anne");
        students.Add("Tom");
        students.Add("Riya");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        students.Sort();

        Console.WriteLine("\nSorted List: ");
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
