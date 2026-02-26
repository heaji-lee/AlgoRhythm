using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class RemoveElementTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new RemoveElement();
        var result = solver.Solve(new int[] { 3, 2, 2, 3 }, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new RemoveElement();
        var result = solver.Solve(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
        Assert.Equal(5, result);
    }
}
