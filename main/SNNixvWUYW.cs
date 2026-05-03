using System;
using System.Collections.Generic;
using System.Linq;
class StringProcessor
{
    public static void Main(string[] args)
    {
        List<string> strings = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };
        var results = ProcessStrings(strings);
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
    public static IEnumerable<string> ProcessStrings(IEnumerable<string> input)
    {
        return input.Select(s => s.ToUpper()).Distinct().OrderBy(s => s);
    }
    public static void PrintSummary(IEnumerable<string> input)
    {
        Console.WriteLine($"Total unique strings: {input.Distinct().Count()}");
    }
    public static string ConcatenateStrings(IEnumerable<string> input)
    {
        return string.Join(", ", input);
    }
    public static IEnumerable<string> GetFilteredStrings(IEnumerable<string> input, int minLength)
    {
        return input.Where(s => s.Length >= minLength);
    }
    public static void PrintFilteredStrings(IEnumerable<string> input, int minLength)
    {
        var filtered = GetFilteredStrings(input, minLength);
        foreach (var str in filtered)
        {
            Console.WriteLine(str);
        }
    }
    public static int CountVowels(string str)
    {
        return str.Count(c => "aeiouAEIOU".Contains(c));
    }
    public static void PrintVowelCounts(IEnumerable<string> input)
    {
        foreach (var str in input)
        {
            Console.WriteLine($"{str}: {CountVowels(str)} vowels");
        }
    }
}
