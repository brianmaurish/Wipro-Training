
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }
}