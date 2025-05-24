class Program
{
    static async Task DownloadFileAsync(string fileName, int delayMs)
    {
        Console.WriteLine($"Starting download: {fileName}");
        await Task.Delay( delayMs );
    }

    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting all downloads...\n");

        Task file1 = DownloadFileAsync("file1.pdf", 3000);
        Task file2 = DownloadFileAsync("file2.pdf", 2000);
        Task file3 = DownloadFileAsync("file3.pdf", 4000);

        Task completed = await Task.WhenAny(file1, file2, file3);

        if(completed== file1)
        {
            Console.WriteLine("file 1 completed");
        }
        else if(completed== file2)
        {
            Console.WriteLine("file 2 completed");
        }
        else
        {
            Console.WriteLine("file 3 comppleted");
        }


    }

}