class Program
{ 
    public static void Main()
    {
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = FindSum(num);
        Console.WriteLine("Number of words: " + sum);
    }
    static int FindSum(int num)
    {
        int result = 0;

        while(num>0)
        {
            int digit = num % 10;
            result = result + digit;
            num = num / 10;
        }
        return result;
        
    }
}



