namespace AlgoRhythm.Problems.Easy;

public class LengthLastWord {
    public int Solve(string s) {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var numberOfWords = words.Length;
        var longestWord = words[numberOfWords - 1];

        return longestWord.Length;
    }
}
