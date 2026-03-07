using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class PlusOneTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new PlusOne();
        var result = solver.Solve([1, 2, 3]);
        Assert.Equal([1, 2, 4], result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new PlusOne();
        var result = solver.Solve([4, 3, 2, 1]);
        Assert.Equal([4, 3, 2, 2], result);
    }

    [Fact]
    public void Example3_ReturnsCorrectResult() {
        var solver = new PlusOne();
        var result = solver.Solve([9]);
        Assert.Equal([1, 0], result);
    }
}
