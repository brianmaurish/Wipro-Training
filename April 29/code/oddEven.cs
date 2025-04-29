
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("The number is: "+ oddEven(num));
    }
    
    static String oddEven(int a)
    {
        if (a%2==0)
        {
            return "Even";
        }
        else
        {
            return "odd";
        }
        
    }
 
    
}