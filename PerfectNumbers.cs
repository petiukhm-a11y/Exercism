using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number must be a positive integer.");
        }

        if (number == 1)
        {
            return Classification.Deficient;
        }

        int sum = 1;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
                int pair = number / i;
                if (pair != i)
                {
                    sum += pair;
                }
            }
        }

        return sum switch
        {
            _ when sum == number => Classification.Perfect,
            _ when sum > number => Classification.Abundant,
            _ => Classification.Deficient
        };
    }
}
