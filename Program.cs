namespace InlineMethodBaseline;

public class Program
{
    public static void Main(string[] args)
    {
        var oneMethod = OneMethod.Create(BenchmarkMethods.Size);
        var inlineMethods = InlineMethods.Create(BenchmarkMethods.Size);

        Console.WriteLine($"OneMethod length: {oneMethod.Length}");
        Console.WriteLine($"InlineMethods length: {inlineMethods.Length}");

        _ = BenchmarkRunner.Run(typeof(Program).Assembly);

        Console.ReadKey();
    }
}