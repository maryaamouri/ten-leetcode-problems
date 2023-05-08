using static ten_leetcode_problems.LongestCommonPrefix;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        var[] strs = { "flower", "flow", "flight" };
        
        var longestCommon = GetLongestCommonPrefix(strs);
        Console.WriteLine("Question #2");
        Console.WriteLine($"Get the Longest Common Prefix between {string.Join(" , ", strs)} ");
        if (longestCommon.Length > 0)
            Console.WriteLine(longestCommon);
        else
            Console.WriteLine(" \" \" ");


    }
}