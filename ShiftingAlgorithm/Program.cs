int[] values = new [] { 4, 5, 6, 1, 2, 3 };

Console.WriteLine("Before: {0}", string.Join(" ", values));

values = Shifter.Shift(values, 3);

Console.WriteLine("After: {0}", string.Join(" ", values));