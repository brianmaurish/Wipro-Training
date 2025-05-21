
class Program
{
    static void FindMinimumCoins(int amount)
    {
        int[] denominations = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        List<int> coinsUsed = new List<int>();

        foreach (int coin in denominations)
        {
            while (amount >= coin)
            {
                amount -= coin;
                coinsUsed.Add(coin);
            }
        }

        Console.WriteLine("Coins used: " + string.Join(", ", coinsUsed));
        Console.WriteLine("Total coins: " + coinsUsed.Count);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter amount: ");
        int amount = int.Parse(Console.ReadLine());

        FindMinimumCoins(amount);
    }
}