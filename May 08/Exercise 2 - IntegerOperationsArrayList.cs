using System;
using System.Collections;
using System.Globalization;
class Program
{
    public static void Main()
    {
        ArrayList numbers = new ArrayList() { 5, 12, 34, 22, 45, 7, 19, 15, 27, 32 };
        numbers.Sort();
        Console.WriteLine("The maximum value is: " + numbers[9]);
        Console.WriteLine("The minimun value is: " + numbers[0]);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum=sum+num;
        }
        int average=sum/numbers.Count;
        Console.WriteLine("The average is: " + average);

    }

}
