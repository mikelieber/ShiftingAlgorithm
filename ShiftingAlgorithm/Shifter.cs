using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ShiftingAlgorithm.Tests")]
namespace ShiftingAlgorithm;

internal static class Shifter
{
    private static int Gcd(int a, int b)
    {
        if (b == 0)
            return a;

        return Gcd(b, a % b);
    }

    internal static T[] Shift<T>(T[] values, int rotateTimes)
    {
        rotateTimes = rotateTimes % values.Length;
        int g = Gcd(rotateTimes, values.Length);

        for (int i = 0; i < g; i++)
        {
            T temp = values[i];
            int j = i;
            
            while(true)
            {
                int k = j + rotateTimes;
                if (k >= values.Length)
                    k = k - values.Length;

                if (k == i)
                    break;

                values[j] = values[k];
                j = k;
            }

            values[j] = temp;
        }

        return values;
    }
}