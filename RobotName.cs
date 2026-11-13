using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random Random = new();
    private static readonly HashSet<string> UsedNames = new();
    private string _name = string.Empty;

    public string Name
    {
        get
        {
            if (string.IsNullOrEmpty(_name))
            {
                _name = GenerateUniqueName();
            }

            return _name;
        }
    }

    public void Reset() => _name = string.Empty;

    private static string GenerateUniqueName()
    {
        string name;
        do
        {
            char letter1 = (char)Random.Next('A', 'Z' + 1);
            char letter2 = (char)Random.Next('A', 'Z' + 1);
            int number = Random.Next(0, 1000);
            name = $"{letter1}{letter2}{number:D3}";
        }
        while (!UsedNames.Add(name));

        return name;
    }
}
