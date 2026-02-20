using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class RomanToIntegerTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new RomanToInteger();
        var result = solver.RomanToIntger("III");
        Assert.Equal(3, result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new RomanToInteger();
        var result = solver.RomanToIntger("LVIII");
        Assert.Equal(58, result);
    }

    [Fact]
    public void Example3_ReturnsCorrectResult() {
        var solver = new RomanToInteger();
        var result = solver.RomanToIntger("MCMXCIV");
        Assert.Equal(1994, result);
    }
}
