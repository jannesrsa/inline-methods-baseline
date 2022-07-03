namespace InlineMethodBaseline;

public class OneMethod
{
    public static string Create(int size)
    {
        var sizeSqrt = (int)Math.Sqrt(size);

        var bigString = string.Empty;
        for (int i = 0; i < sizeSqrt; i++)
        {
            bigString += new string('1', sizeSqrt);
        }

        return bigString;
    }
}