class Program
{
    static void TowerOfHanoi(int n, char s, char a, char d)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {s} to {d}");
            return;
        }

        // Move n-1 disks from source to auxiliary
        TowerOfHanoi(n - 1, s, d, a);

        // Move the nth disk from source to destination
        Console.WriteLine($"Move disk {n} from {s} to {d}");

        // Move the n-1 disks from auxiliary to destination
        TowerOfHanoi(n - 1, a, s, d);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of disks: ");
        int n = Convert.ToInt32(Console.ReadLine());

        TowerOfHanoi(n, 'A', 'B', 'C'); // A: source, B: auxiliary, C: destination
    }
}