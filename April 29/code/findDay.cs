
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any number from 1 to 7 to find the day: ");
        int num=Convert.ToInt32(Console.ReadLine());
        
        switch (num)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
        }
        
    }
    
}