using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


class TestClass
{

    static void Main()
    {
        Action<int> printActionDel = ConsolePrint;
        Action<int> printToPrinter = PrinterPrint;

        printActionDel(10);
        printToPrinter(45);
    }
        public static void ConsolePrint(int i)
        {
        Console.WriteLine(i);
        }
        public static void PrinterPrint(int i)
        {
        Console.WriteLine("This is being printed to the printer");
        }
    
}




