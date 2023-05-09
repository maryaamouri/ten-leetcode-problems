﻿using ten_leetcode_problems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        //Question #9
        Console.WriteLine("----------------");
        Console.WriteLine("Qestion#9: Set Mismatch");
        var testCase91 = { 1, 2, 2, 4 };
        var testCase92 = { 1, 1 };
        var result91 = MissMatch.Find(testCase91);
        var result92 = MissMatch.Find(testCase92);
        Console.WriteLine($"Test Case1: [1,2,2,4] => The mismatch : [{result91[0]},{result91[1]}]");
        Console.WriteLine($"Test Case2: [1,1] => The mismatch : [{result92[0]},{result92[1]}]");

    }
}