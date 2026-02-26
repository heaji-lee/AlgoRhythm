using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class ValidParanthesesTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new ValidParantheses();
        var result = solver.IsValid("()");
        Assert.True(result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new ValidParantheses();
        var result = solver.IsValid("()[]{}");
        Assert.True(result);
    }

    [Fact]
    public void Example3_ReturnsCorrectResult() {
        var solver = new ValidParantheses();
        var result = solver.IsValid("(]");
        Assert.False(result);
    }

    [Fact]
    public void Example4_ReturnsCorrectResult() {
        var solver = new ValidParantheses();
        var result = solver.IsValid("([])");
        Assert.True(result);
    }

    [Fact]
    public void Example5_ReturnsCorrectResult() {
        var solver = new ValidParantheses();
        var result = solver.IsValid("([)]");
        Assert.False(result);
    }
}
