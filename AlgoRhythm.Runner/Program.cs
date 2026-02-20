using System.Runtime.CompilerServices;
using AlgoRhythm.Problems.Easy;
using AlgoRhythm.Tests.Easy;

Console.WriteLine("=== AlgoRhythm Runner ===\n");

void RunTests<T>(T testClass) {
    var testType = typeof(T);
    var methods = testType.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
    int total = 0;
    int passed = 0;

    Console.WriteLine($"Running {testType.Name} tests...\n");

    foreach (var method in methods) {
        if (method.GetCustomAttributes(typeof(Xunit.FactAttribute), false).Length > 0) {
            total++;
            try {
                method.Invoke(testClass, null);
                Console.WriteLine($"{method.Name}: Passed ✅");
                passed++;
            } catch (Exception ex) {
                Console.WriteLine($"{method.Name}: Failed ❌");
                Console.WriteLine($"  {ex.InnerException?.Message ?? ex.Message}");
            }
        }
    }

    Console.WriteLine($"\n{passed}/{total} tests passed for {testType.Name}.\n");
}

var twoSumTests = new TwoSumTests();
RunTests(twoSumTests);

var solver = new TwoSum();
var sampleInput = new[] { 2, 7, 11, 15 };
var target = 9;
var result = solver.Solve(sampleInput, target);

Console.WriteLine("Sample run for TwoSum:");
Console.WriteLine($"Input: [{string.Join(",", sampleInput)}], Target: {target}");
Console.WriteLine($"Output indices: [{string.Join(",", result)}]");
