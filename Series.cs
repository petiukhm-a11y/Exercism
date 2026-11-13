using System;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (string.IsNullOrEmpty(numbers) || sliceLength <= 0 || sliceLength > numbers.Length)
        {
            throw new ArgumentException("Invalid slice length or input string.");
        }

        return Enumerable.Range(0, numbers.Length - sliceLength + 1)
            .Select(i => numbers.Substring(i, sliceLength))
            .ToArray();
    }
}
