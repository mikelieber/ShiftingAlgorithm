namespace ShiftingAlgorithm.Tests;

public class SwapTests
{
    [Fact]
    public void Swap_IntValues_Swapped()
    {
        int a = 1, b = 2;

        Swapper.Swap(ref a, ref b);
        
        Assert.True(a == 2 && b == 1);
    }

    [Fact]
    public void Swap_NullValues_DoesNotThrow()
    {
        object? a = null, b = null;

        var exception = Record.Exception(() => Swapper.Swap(ref a, ref b));

        Assert.Null(exception);
    }

    [Fact]
    public void Swap_Strings_Swapped()
    {
        string a = "hello", b = "world";
        string a_temp = a;
        
        Swapper.Swap(ref a, ref b);

        Assert.NotEqual(a, a_temp);
    }
}