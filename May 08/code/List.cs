
class Program
{
    public static void Main(string[] args)
    {
        //Creating list of integers
        List<string> fruits = new List<string>() { "Apple", "Orange", "Cherry" };

        //Adding elements
        fruits.Add("Mango");

        //Inserting at particular index
        fruits.Insert(1, "Banana");

        //Removing an element
        fruits.Remove("Banana");

        //Removing element using index
        fruits.RemoveAt(2);

        //Check if an element is present or not
        if (fruits.Contains("Apple"))
            Console.WriteLine("Apple is in the list");

        //Sorting the elements in list
        fruits.Sort();

        //Printing elements
        Console.WriteLine("Fruits List: ");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit+" ");
        }
    }
}

