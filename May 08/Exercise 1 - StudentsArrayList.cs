using System;
using System.Collections;
using System.Globalization;
class Program
{
    public static void Main()
    {
        ArrayList students = new ArrayList();

        //Insert to ArrayList
        students.Add("Tom");
        students.Add("Berg");
        students.Add("Zack");
        students.Add("Jenny");
        students.Add("Ross");

        //Remove by value
        students.Remove("Ross");

        //Print the elements in ArrayList
        Console.WriteLine("The list of students: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        //Check if an element is present or not
        if (students.Contains("Jenny"))
        {
            Console.WriteLine("Jenny is present");
        }
        else
        {
            Console.WriteLine("Jenny is not present");
        }

    }

}
