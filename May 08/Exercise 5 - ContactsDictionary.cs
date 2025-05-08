class Program
{
    public static void Main()
    {
        //Creating a Dictionary
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        //Adding elements
        contacts.Add("Roy","1239871234");
        contacts.Add("Bobby","1237865456");
        contacts.Add("Charlie","1238976543");
        contacts.Add("Leo", "1230987687");
        contacts.Add("Jim", "1238976545");

        //Updating phone number of Roy
        contacts["Roy"] = "1236785432";

        //Check if Jim exists or not
        if(contacts.ContainsKey("Jim"))
        {
            Console.WriteLine("Jim is present");
        }
        else
        {
            Console.WriteLine("Jim is not present");
        }

        //Print all the contacts
        foreach (var student in students)
        {
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }

        
    }
}
