using static ten_leetcode_problems.ValidParantheses;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");

        // Q4
        Console.WriteLine("Question #4:");
        string parantheses = "()[]{}";
        bool isValidParantheses = IsValidParentheses(parantheses);
        Console.WriteLine($"The string {parantheses} considered as {isValidParantheses} valid parantheses");
    }
}