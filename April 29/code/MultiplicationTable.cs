
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine(num +"*"+i+"="+i*num);
        }
        
    }
    
}