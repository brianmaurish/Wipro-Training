class Program
{
    public static void Main(String[] args)
    {
        List<int>list = new List<int> { 2,3,4,5,7,1,2,3,9,8,3,4,2,5,6,7 };
        var a = from b in list
                group b by b into c
                select new { number = c.Key, count = c.Count() };

        Console.WriteLine("The duplicate numbers are: ");

        foreach( var num in a)
        {
            if(num.count>=2)
            {
                Console.WriteLine(num.number);
            }
        }
    }
}

