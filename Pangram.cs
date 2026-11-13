using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input) =>
        input.ToLowerInvariant()
             .Where(c => c is >= 'a' and <= 'z')
             .Distinct()
             .Count() == 26;
}
