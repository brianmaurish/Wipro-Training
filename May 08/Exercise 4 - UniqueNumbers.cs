class Program
{
    public static void Main(string[] args)
    {
        //Create list with duplicate numbers
        List<int> numbers = new List<int> { 1, 2, 3, 6, 1, 2, 6, 4, 3, 7 };
            
        HashSet<int> set = new HashSet<int>();

        foreach (int i in numbers)
        {
            set.Add(i);
        }

        //Print the unique numbers
        Console.WriteLine("Unique numbers: ");
        foreach (int i in set)
        {
            Console.WriteLine(i);
        }

        //Print the number of unique numbers present
        Console.WriteLine("The no of unique elements present is: "+set.Count);
       

        
    }
}

