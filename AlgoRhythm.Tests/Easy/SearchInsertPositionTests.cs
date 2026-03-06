using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class SearchInsertPositionTests {
    [Fact]
    public void Example1_ReturnsCorrectIndices() {
        var solver = new SearchInsertPosition();
        var result = solver.Solve(new[] { 1, 3, 5, 6 }, 5);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectIndices() {
        var solver = new SearchInsertPosition();
        var result = solver.Solve(new[] { 1, 3, 5, 6 }, 2);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Example3_ReturnsCorrectIndices() {
        var solver = new SearchInsertPosition();
        var result = solver.Solve(new[] { 1, 3, 5, 6 }, 7);
        Assert.Equal(4, result);
    }
}
