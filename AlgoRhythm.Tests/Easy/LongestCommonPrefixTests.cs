using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class LongestCommonPrefixTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new LongestCommonPrefix();
        var result = solver.Solve(["flower","flow","flight"]);
        Assert.Equal("fl", result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new LongestCommonPrefix();
        var result = solver.Solve(["dog","racecar","car"]);
        Assert.Equal("", result);
    }
}
