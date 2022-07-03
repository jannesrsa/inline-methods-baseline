namespace InlineMethodBaseline;

[MemoryDiagnoser]
[SimpleJob(RunStrategy.Monitoring, launchCount: 1, warmupCount: 1, targetCount: 2)]
public class BenchmarkMethods
{
    public const int Size = 2000000;

    [Benchmark]
    public string BenchmarkInlineMethods()
    {
        return InlineMethods.Create(Size);
    }

    [Benchmark]
    public string BenchmarkOneMethod()
    {
        return OneMethod.Create(Size);
    }
}