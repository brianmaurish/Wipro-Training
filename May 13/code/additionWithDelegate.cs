using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate int SomeOperation(int i,int j);
class TestClass
{
    static int Sum(int x,int y)
    {
        return x + y;
    }
    
    static void Main()
    {
        SomeOperation add = Sum;
        int result = add(10, 10);
        Console.WriteLine(result);

    }
}

