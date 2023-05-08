using static ten_leetcode_problems.ContainsDoublicated;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");

        // Q1

        Console.WriteLine("Question #1:");
        var[] nums = { 1, 2, 3, 1 };
        var k = 3;
        var containsDoublicated = GetContainsNearbyDuplicate(nums, k);
        Console.WriteLine($"Do the array  {string.Join(" , ", nums)} contains doublicated nymbers on k = {k} near indeces?");
        Console.WriteLine(containsDoublicated);


    }
}