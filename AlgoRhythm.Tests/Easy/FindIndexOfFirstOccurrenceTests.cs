using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class FindIndexOfFirstOccurrenceTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new FindIndexOfFirstOccurrence();
        var result = solver.Solve("sadbutsad", "sad");
        Assert.Equal(0, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new FindIndexOfFirstOccurrence();
        var result = solver.Solve("leetcode", "leeto");
        Assert.Equal(-1, result);
    }
}
