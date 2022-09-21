namespace ShiftingAlgorithm.Tests;

public class OddArraysTests
{
    [Fact]
    public void Shift_OddArrayEvenShiftTwo_Shifted()
    {
        int shift = 2;
        int[] values = new[] { 4, 5, 1, 2, 3 };
        int[] expected = new[] { 1, 2, 3, 4, 5 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_OddArrayEvenShiftFour_Shifted()
    {
        int shift = 4;
        int[] values = new[] { 4, 5, 6, 7, 1, 2, 3 };
        int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_OddArrayOddShiftOne_Shifted()
    {
        int shift = 1;
        int[] values = new[] { 4, 1, 2, 3 };
        int[] expected = new[] { 1, 2, 3, 4 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_OddArraySevenOddShiftThree_Shifted()
    {
        int shift = 3;
        int[] values = new[] { 5, 6, 7, 1, 2, 3, 4 };
        int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_OddArrayElevenOddShiftThree_Shifted()
    {
        int shift = 3;
        int[] values = new[] { 9, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_OddArrayNineOddShiftThree_Shifted()
    {
        int shift = 3;
        int[] values = new[] { 7, 8, 9, 1, 2, 3, 4, 5, 6, };
        int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }
}