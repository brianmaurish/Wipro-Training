using System;

public class HelloWorld
{
    static int sum(int a,int b)
    {
        return a+b;
    }
    static double sum(double a,double b)
    {
        return a+b;
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("the sum is: "+sum(2.4,3.5));
    }
    
}
