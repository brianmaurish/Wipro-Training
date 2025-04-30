using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        while(num*num<100)
        {
            Console.WriteLine(num*num);
            num++;
        }
        
    }
}
