namespace InlineMethodBaseline;

public class OneMethod
{
    public static string Create(int size)
    {
        var bigString = string.Empty;
        for (int i = 0; i < size; i++)
        {
            bigString += new string('1', size);
        }

        return bigString;
    }
}