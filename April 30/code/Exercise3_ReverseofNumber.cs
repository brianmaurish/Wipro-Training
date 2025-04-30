using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int revnum=0;
        
        while(num!=0)
        {
            int digit=num%10;
            revnum=revnum*10+digit;
            num=num/10;
        }
        Console.WriteLine("The sum of the number is: "+revnum);
    }
}
