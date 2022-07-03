namespace InlineMethodBaseline;

public class InlineMethods
{
    public static string Create(int size)
    {
        return BuildStrings(size);
    }

    private static string BuildStrings(int size)
    {
        var bigString = string.Empty;
        for (int i = 0; i < size; i++)
        {
            bigString += GetBigString(size);
        }

        return bigString;
    }

    private static string GetBigString(int size)
    {
        return new string('1', size);
    }
}