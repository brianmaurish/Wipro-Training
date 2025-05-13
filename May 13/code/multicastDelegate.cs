using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


delegate void CustomDel(string s);
class TestClass
{
    static void Hello(string s)
    {
        Console.WriteLine($"Hello, {s}!");
    }
    static void Goodbye(string s)
    {
        Console.WriteLine($"Goodbye, {s}!");
    }
    static void Main()
    {
        //Create instances of the custom delegate
        CustomDel hiDel, byeDel, multiDel;
        hiDel = Hello; //Delegate object that reference the method
        byeDel= Goodbye;

        multiDel = hiDel + byeDel; //Two delegates are combined to form multiDel
        Console.WriteLine("Invoking delegate hiDel:");
        hiDel("A");
        Console.WriteLine("Invoking delegate byeDel:");
        byeDel("B");
        Console.WriteLine("Invoking delegate multiDel:");
        multiDel("C");
    }
}

