using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ShiftingAlgorithm.Tests")]
namespace ShiftingAlgorithm;

internal static class Swapper
{
    internal static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}