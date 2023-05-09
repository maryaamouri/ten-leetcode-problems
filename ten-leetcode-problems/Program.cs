using ten_leetcode_problems;
using static ten_leetcode_problems.BinaryTreeAllPaths;
using static ten_leetcode_problems.CreateSampleTreeNode;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        // Question5
        Console.WriteLine("Question #5:");
        Console.WriteLine("All possible paths are");
        var root = CreateSampleTreeNode();
        IList<string> paths = GetBinaryTreePths(root);
        foreach (string path in paths)
        {
            Console.WriteLine(path);
        }
    }
}