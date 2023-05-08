using static ten_leetcode_problems.LongestPalendrom;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        // Q3
        var s = "abccccdd";
        Console.WriteLine("Question #3:");
        var longestPalendrome = GetLongestPalindrome(s);
        Console.WriteLine($"The Longest Palendron String that can be generated from {s} is {longestPalendrome}");

    }
}