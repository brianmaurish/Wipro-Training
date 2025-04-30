using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum=0;
        
        while(num!=0)
        {
            int digit=num%10;
            sum=sum+digit;
            num=num/10;
        }
        Console.WriteLine("The sum of the number is: "+sum);
    }
}
