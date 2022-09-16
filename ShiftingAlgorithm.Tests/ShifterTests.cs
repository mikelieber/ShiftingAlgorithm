namespace ShiftingAlgorithm.Tests;

public class ShifterTests
{
    private readonly Random random = new();

    [Fact]
    public void Shift_IntArray_FirstNPushedToEnd()
    {
        int[] values = new [] { 9, 10, 1, 2, 3, 4, 5, 6, 7, 8 };

        values = Shifter.Shift(values, 2);
        
        Assert.True(values[9] == 10);
    }

    [Fact]
    public void Shift_RandomIntValues_LastToShiftAtEnd()
    {
        int maxShift = random.Next(3, 15);
        int[] values = new int[random.Next(maxShift + maxShift, 100)];

        for (int i = 0; i > values.Length; i++)
            values[i] = random.Next(0, 100);

        int temp = values[maxShift - 1];

        Shifter.Shift(values, maxShift);

        Assert.True(values[values.Length - 1] == temp);
    }
}