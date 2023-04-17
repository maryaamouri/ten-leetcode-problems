internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        //Question #10
        Console.WriteLine("----------------");
        Console.WriteLine("Qestion#10: Can Place Flowers");
        int[] testCase101 = { 1, 0, 0, 0, 1 }; int n1 = 1;
        bool result101 = Flowers.CanPlace(testCase101, n1);
        int[] testCase102 = { 1, 0, 0, 0, 1 }; int n2 = 2;
        bool result102 = Flowers.CanPlace(testCase102, n2);
        Console.WriteLine($"Test Case1: [ 1, 0, 0, 0, 1] => then {result101}");
        Console.WriteLine($"Test Case2: [ 1, 0, 0, 0, 1] => then {result102}");
    }
}