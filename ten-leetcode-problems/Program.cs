﻿using ten_leetcode_problems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        //Question #8
        Console.WriteLine("----------------");
        Console.WriteLine("Qestion#8: Maximum Depth of Binary Tree");
        TreeNode root = MaximumDepth.CreateSampleTreeNode();
        int maxDepth = MaximumDepth.Get(root);
        Console.WriteLine($"max depth = {maxDepth}");
    }
}