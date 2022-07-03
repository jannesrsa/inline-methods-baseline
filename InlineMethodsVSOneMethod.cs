namespace InlineMethodBaseline;

[MemoryDiagnoser]
public class InlineMethodsVSOneMethod
{
    private const int _size = 10;

    [Benchmark]
    public void BenchmarkInlineMethods()
    {
        InlineMethods.Create(_size);
    }

    [Benchmark]
    public void BenchmarkOneMethod()
    {
        OneMethod.Create(_size);
    }
}