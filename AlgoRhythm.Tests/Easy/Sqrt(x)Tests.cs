using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class SqrtTests {
    [Fact]
    public void Example1_ReturnsCorrectIndices() {
        var solver = new Sqrt();
        var result = solver.Solve(4);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectIndices() {
        var solver = new Sqrt();
        var result = solver.Solve(8);
        Assert.Equal(2, result);
    }
}
