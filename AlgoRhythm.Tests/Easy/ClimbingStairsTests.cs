using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class ClimbingStairsTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new ClimbingStairs();
        var result = solver.Solve(2);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new ClimbingStairs();
        var result = solver.Solve(3);
        Assert.Equal(3, result);
    }
}
