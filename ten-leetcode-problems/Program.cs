using ten_leetcode_problems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        //Question #7
        Console.WriteLine("----------------");
        Console.WriteLine("Qestion#7: Fizz Buzz");
        Console.WriteLine("Test Case 1");
        int testCase21 = 3;
        IList<string> result1 = Fizz_Buzz.FindFizzBuzz(testCase21);
        Console.WriteLine(string.Join(", ", result1));
        int testCase22 = 5;
        Console.WriteLine("Test Case 2");
        IList<string> result2 = Fizz_Buzz.FindFizzBuzz(testCase22);
        Console.WriteLine(string.Join(", ", result2));
        Console.WriteLine("Test Case 3");
        int testCase23 = 15;
        IList<string> result3 = Fizz_Buzz.FindFizzBuzz(testCase23);
        Console.WriteLine(string.Join(", ", result3));
    }
}