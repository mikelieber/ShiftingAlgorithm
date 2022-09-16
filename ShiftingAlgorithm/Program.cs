int[] values = new [] { 9, 10, 11, 1, 2, 3, 4, 5, 6, 7, 8 };

Console.WriteLine("Before: {0}", string.Join(" ", values));

values = Shifter.Shift(values, 3);

Console.WriteLine("After: {0}", string.Join(" ", values));