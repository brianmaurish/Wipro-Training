
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter 1st number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter 2nd number: ");
        int b=Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter 3rd number: ");
        int c=Convert.ToInt32(Console.ReadLine());
        
        if (a >= b && a >= c)
        {
            Console.WriteLine(a+" is the greatest number");
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine(b+" is the greatest number");
        }
        else
        {
            Console.WriteLine(c+" is the greatest number");
        }
    }
    
}