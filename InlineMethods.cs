namespace InlineMethodBaseline;

public class InlineMethods
{
    public static string Create(int size)
    {
        var returnVal = BuildStrings(size);
        return returnVal;
    }

    private static string BuildStrings(int size)
    {
        var sizeSqrt = (int)Math.Sqrt(size);

        var returnVal = string.Empty;
        for (int i = 0; i < sizeSqrt; i++)
        {
            var otherString = GetBigString(sizeSqrt);
            returnVal += otherString;
        }

        return returnVal;
    }

    private static string GetBigString(int size)
    {
        var returnVal = new string('1', size);
        return returnVal;
    }
}