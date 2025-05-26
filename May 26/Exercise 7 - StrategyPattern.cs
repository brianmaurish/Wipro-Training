public abstract class CompressionStrategy
{
    public abstract void Compress(string inputPath, string outputPath);
}

public class ZipCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing '{inputPath}' to ZIP format at '{outputPath}'...");
    }
}

public class RarCompression : CompressionStrategy
{
    public override void Compress(string inputPath, string outputPath)
    {
        Console.WriteLine($"Compressing '{inputPath}' to RAR format at '{outputPath}'...");
    }
}

public class Compressor
{
    private readonly CompressionStrategy _compressionStrategy;

    public Compressor(CompressionStrategy compressionStrategy)
    {
        _compressionStrategy = compressionStrategy;
    }

    public void CompressFile(string inputPath, string outputPath)
    {
        _compressionStrategy.Compress(inputPath, outputPath);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Compressor zipCompressor = new Compressor(new ZipCompression());
        zipCompressor.CompressFile("file.txt", "file.zip");

        Compressor rarCompressor = new Compressor(new RarCompression());
        rarCompressor.CompressFile("file.txt", "file.rar");

    }
}