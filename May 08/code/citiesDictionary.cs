class Program
{
    public static void Main()
    {
        //Creating a Dictionary
        Dictionary<string, string> cities = new Dictionary<string, string>
        {
            {"Mumbai", "Maharastra"},
            {"Banglore", "Karnataka"},
            {"CHENNAI", "TAMILNADU"},
            {"KOLKATA", "WEST BENGAL"},
            {"HYDERABAD", "TELANGANA"}
         };

        //Check if the specific city exists
        if(cities.ContainsKey("CHENNAI"))
        {
            Console.WriteLine("CHENNAI IS PRESENT IN THE DICTIONARY");
        }

        //Looping through the dictionary
        Console.WriteLine("Indian cities and states: ");
        foreach (var city in cities)
        {
            {
                Console.WriteLine($"ID: {city.Key}, Name: {city.Value}");

            }
        }
    }
}
