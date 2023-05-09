internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");
        //Question #10
        Console.WriteLine("----------------");
        Console.WriteLine("Qestion#10: Can Place Flowers");
        var testCase101 = { 1, 0, 0, 0, 1 }; int n1 = 1;
        var result101 = Flowers.CanPlace(testCase101, n1);
        var testCase102 = { 1, 0, 0, 0, 1 }; int n2 = 2;
        var result102 = Flowers.CanPlace(testCase102, n2);
        Console.WriteLine($"Test Case1: [ 1, 0, 0, 0, 1] => then {result101}");
        Console.WriteLine($"Test Case2: [ 1, 0, 0, 0, 1] => then {result102}");
    }
}