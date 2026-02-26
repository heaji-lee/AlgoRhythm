using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class RemoveDuplicatesFromSortedArrayTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new RemoveDuplicatesFromSortedArray();
        var result = solver.Solve([1, 1, 2]);
        Assert.Equal(2, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new RemoveDuplicatesFromSortedArray();
        var result = solver.Solve([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
        Assert.Equal(5, result);
    }
}
