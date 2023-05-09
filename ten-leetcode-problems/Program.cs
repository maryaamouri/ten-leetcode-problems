using static ten_leetcode_problems.ReverseString;
using ten_leetcode_problems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        //Question #6
        Console.WriteLine("Qestion#6: Reverse A string");
        //Question #6
        Console.WriteLine("Qestion#6: Reverse A string");
        Console.WriteLine("Test Case 1");
        var testCase11 = { 'h', 'e', 'l', 'l', 'o' };
        Console.WriteLine(testCase11);
        ReverseString.Reverse(testCase11);
        Console.WriteLine(testCase11);
        Console.WriteLine("Test Case 2");
        var testCase12 = { 'H', 'a', 'n', 'n', 'a', 'h' };
        Console.WriteLine(testCase12);
        ReverseString.Reverse(testCase12);
        Console.WriteLine(testCase12);

    }
}