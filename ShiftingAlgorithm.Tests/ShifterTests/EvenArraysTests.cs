namespace ShiftingAlgorithm.Tests;

public class EvenArraysTests
{
    [Fact]
    public void Shift_EvenArrayEvenShiftTwo_Shifted()
    {
        int shift = 2;
        int[] values = new[] { 3, 4, 1, 2 };
        int[] expected = new[] { 1, 2, 3, 4 };
        
        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_EvenArrayEvenShiftFour_Shifted()
    {
        int shift = 4;
        int[] values = new[] { 5, 6, 7, 8, 1, 2, 3, 4 };
        int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        
        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_EvenArrayOddShiftOne_Shifted()
    {
        int shift = 1;
        int[] values = new[] { 4, 1, 2, 3 };
        int[] expected = new[] { 1, 2, 3, 4 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }

    [Fact]
    public void Shift_EvenArrayOddShiftThree_Shifted()
    {
        int shift = 3;
        int[] values = new[] { 4, 5, 6, 1, 2, 3 };
        int[] expected = new[] { 1, 2, 3, 4, 5, 6 };

        Shifter.Shift(values, shift);

        Assert.Equal(expected, values);
    }
}