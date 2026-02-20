using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class TwoSumTests {
    [Fact]
    public void Example1_ReturnsCorrectIndices() {
        var solver = new TwoSum();
        var result = solver.Solve(new[] { 2, 7, 11, 15 }, 9);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectIndices() {
        var solver = new TwoSum();
        var result = solver.Solve(new[] { 3, 2, 4 }, 6);
        Assert.Equal(new[] { 1, 2 }, result);
    }

    [Fact]
    public void Example3_ReturnsCorrectIndices() {
        var solver = new TwoSum();
        var result = solver.Solve(new[] { 3, 3 }, 6);
        Assert.Equal(new[] { 0, 1 }, result);
    }
}
