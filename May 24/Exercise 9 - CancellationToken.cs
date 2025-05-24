using System.Diagnostics;

class Program
{
    static async Task DoWorkAsync(CancellationToken token)
    {
        for(int i =1; i <=10; i++)
        {
            if(token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requestd, Exiting....");
                return;
            }
            Console.WriteLine(i);
            await Task.Delay(1000);
        }
    }

    static async Task Main(string[] args)
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        Task work = DoWorkAsync(token);
        await Task.Delay(2000);
        cts.Cancel();

        await work;
    }

}