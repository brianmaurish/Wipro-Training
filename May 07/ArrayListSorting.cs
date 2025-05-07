using System;
using System.Collections;
using System.Globalization;
class Program
{
    public static void Main()
    {
        ArrayList numbers = new ArrayList() { 5, 6, 2, 3, 9, 1, 7, 3 };
        numbers.Sort();
        Console.WriteLine("Sorted: ");
        foreach (var num in numbers)
        {
            Console.Write(num+" ");
        }

        Console.WriteLine();
        numbers.Reverse();
        Console.WriteLine("Reversed: ");
        foreach (var num in numbers)
        {
            Console.Write(num+" ");
        }
    }
    
}
