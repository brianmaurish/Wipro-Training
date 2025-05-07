using System;
using System.Collections;
using System.Globalization;
class Program
{
    public static void Main()
    {
        ArrayList students = new ArrayList();

        //Insert to ArrayList
        students.Add("Glen");
        students.Add("Matt");
        students.Add("Zack");
        students.Add("Jenny");
        students.Add("Ross");

        //Check if an element is present or not
        if (students.Contains("Jenny"))
        {
            Console.WriteLine("Jenny is present");
        }
        else
        {
            Console.WriteLine("Jenny is not present");
        }
                
        //Remove the second element
        students.RemoveAt(1);


        //Print the elements in ArrayList
        Console.WriteLine("The list of students: ");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        
    }
    
}
