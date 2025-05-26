class Program
{
    static async Task Main(string[] args)
    {

        List<string> imageFiles = new List<string>();
        for (int i = 1; i <= 20; i++)
        {
            imageFiles.Add($"Image{i}.jpg");
        }

        int totalImages = imageFiles.Count;
        int processedImages = 0;

        await Parallel.ForEachAsync(imageFiles, async (image, cancellationToken) =>
        {
            await Task.Delay(200); 

            processedImages++;
            double progress = (double)processedImages / totalImages * 100;
            Console.WriteLine($"Progress: {progress:0.0}%");
        });

        Console.WriteLine("All images processed!");
    }
}