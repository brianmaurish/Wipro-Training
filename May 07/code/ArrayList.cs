using System.Collections;
class Program
{
    public static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);

        //Insert an element into list
        list.Insert(1, "Orange");
        Console.WriteLine("Element at index 1: " + list[1]);

        //Check if an element is present in list
        if (list.Contains(42))
        {
            Console.WriteLine("42 is present");
        }
        else
        {
            Console.WriteLine("42 is not present");
        }

        list.RemoveAt(0); //Removes element at index 0
        list.Remove(42); //Removes the element 42

        //Print the elements in the list
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

    }
    
}
