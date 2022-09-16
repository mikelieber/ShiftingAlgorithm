using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ShiftingAlgorithm.Tests")]
namespace ShiftingAlgorithm;

internal static class Shifter
{
    internal static T[] Shift<T>(T[] values, int endIndex)
    {
        for (int i = 0; i < endIndex; i++)
        {
            for (int j = 0; j < values.Length - 1; j++)
            {
                T temp = values[j + 1];
                values[j + 1] = values[j];
                values[j] = temp;
            }
        }

        return values;
    }
}