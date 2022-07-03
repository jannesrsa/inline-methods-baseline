

namespace InlineMethodBaseline;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
        //var oneMethod = OneMethod.Create(1000);
        //var inlineMethods = InlineMethods.Create(1000);

        //Console.WriteLine($"OneMethod length: {oneMethod.Length}");
        //Console.WriteLine($"InlineMethods length: {inlineMethods.Length}");

        Console.ReadKey();
    }
}