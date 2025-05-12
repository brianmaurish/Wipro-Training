using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suman" };
        //UsingLinqQuery(names);
        //UsingLinqExtensions(names);
        UsingLinqFunctions(names);
    }

    /*private static void UsingLinqQuery(string[] names)
    {
        IEnumerable<string> query = from s in names
                                     where s.Length ==5
                                     orderby s
                                     select s.ToUpper();


        foreach (string item in query)
        {
            Console.WriteLine(item);
        }
    }*/

    /*private static void UsingLinqExtensions(string[] names)
    {

        IEnumerable<string> query = names
                                     .Where(s => s.Length == 5)
                                     .OrderBy(s => s)
                                     .Select(s => s.ToUpper());
                                      

        foreach(string item in query)
        {
            Console.WriteLine(item);
        }
    }*/

    private static void UsingLinqFunctions(string[] names)
    {
        Func<string, bool> filter=s=>s.Length == 5;
        Func<string, string> extract = s => s;
        Func<string,string> project = s => s.ToUpper();

        IEnumerable<string> query = names.Where(filter)
                                            .OrderBy(extract)
                                            .Select(project);


        foreach (string item in query)
        {
            Console.WriteLine(item);
        }
    }

}
