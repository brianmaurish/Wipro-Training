using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<int> Marks { get; set; }

    public Student(int id, string name, List<int> marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }

    public double AverageMarks => Marks.Average();
    public int HighestMarks => Marks.Max();
    public int LowestMarks => Marks.Min();
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student(1, "Jack", new List<int> { 82, 90, 76 }),
            new Student(2, "Charan", new List<int> { 88, 94, 91 }),
            new Student(3, "Tim", new List<int> { 75, 80, 72 }),
            new Student(4, "David", new List<int> { 95, 89, 93 }),
            new Student(5, "John", new List<int> { 85, 90, 88 })
        };

        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            Console.WriteLine($"Marks: {string.Join(", ", student.Marks)}");
            Console.WriteLine($"Average: {student.AverageMarks}, Highest: {student.HighestMarks}, Lowest: {student.LowestMarks}");
            Console.WriteLine();
        }

        var topStudents = students.OrderByDescending(s => s.AverageMarks).Take(3);

        Console.WriteLine("Top 3 Students:");
        foreach (var student in topStudents)
        {
            Console.WriteLine($"{student.Name} - Average: {student.AverageMarks}");
        }
    }
}
