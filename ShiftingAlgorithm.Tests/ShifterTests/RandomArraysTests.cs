namespace ShiftingAlgorithm.Tests;

public class RandomArraysTests
{
    private readonly Random random = new();

    private (int[] expected, int[] values, int shift) GenerateTestData()
    {
        int maxShift = random.Next(3, 15);

        var expected = Enumerable.Range(0, random.Next(maxShift * 2, 100)).ToArray();

        int[] values = new int[expected.Length];


        Array.Copy(expected, 0, values, expected.Length - (expected.Length - maxShift), expected.Length - maxShift);
        Array.Copy(expected, expected.Length - maxShift, values, 0, maxShift);

        return (expected, values, maxShift);
    }

    [Fact]
    public void Shift_RandomArrayRandomShift_Shifted()
    {
        var gen = GenerateTestData();

        Shifter.Shift(gen.values, gen.shift);

        Assert.Equal(gen.expected, gen.values);
    }
}
