
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1=10;
        int num2=20;
        
        Console.WriteLine("The multiplication is: "+ multiply(num1,num2));
    }
    
    static int multiply(int a,int b)
    {
        return a*b;
    }
 
    
}