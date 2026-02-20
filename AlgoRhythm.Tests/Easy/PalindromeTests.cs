using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class PalindromeTests
{
    [Fact]
    public void Example1_ReturnsCorrectResult()
    {
        var solver = new Palindrome();
        var result = solver.IsPalindrome(121);
        Assert.True(result);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult()
    {
        var solver = new Palindrome();
        var result = solver.IsPalindrome(-121);
        Assert.False(result);
    }

    [Fact]
    public void Example3_ReturnsCorrectResult()
    {
        var solver = new Palindrome();
        var result = solver.IsPalindrome(10);
        Assert.False(result);
    }
}
