using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be a positive integer.");
        }

        int steps = 0;
        long current = number;

        while (current > 1)
        {
            current = current % 2 == 0 ? current / 2 : current * 3 + 1;
            steps++;
        }

        return steps;
    }
}
