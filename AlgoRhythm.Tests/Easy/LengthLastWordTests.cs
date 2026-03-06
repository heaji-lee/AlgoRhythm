using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class LengthLastWordTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new LengthLastWord();
        var result = solver.Solve("Hello World");
        Assert.Equal(5, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new LengthLastWord();
        var result = solver.Solve("   fly me   to   the moon  ");
        Assert.Equal(4, result);
    }

    [Fact]
    public void Example3_ReturnsCorrectResult() {
        var solver = new LengthLastWord();
        var result = solver.Solve("luffy is still joyboy");
        Assert.Equal(6, result);
    }
}
