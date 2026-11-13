using System.Collections.Generic;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var seen = new HashSet<char>();
        return word.ToLowerInvariant().Where(char.IsLetter).All(seen.Add);
    }
}
