namespace AlgoRhythm.Problems.Easy;

public class RomanToInteger {
    public int RomanToIntger(string s) {

        var dictionary = new Dictionary<char, int> {
          {'I', 1},
          {'V', 5},
          {'X', 10},
          {'L', 50},
          {'C', 100},
          {'D', 500},
          {'M', 1000}
        };

        var result = 0;

        for (int i = 0; i < s.Length; i++) {
            var current = dictionary[s[i]];

            if (i + 1 < s.Length && current < dictionary[s[i + 1]]) {
                result -= current;
            } else {
                result += current;
            }
        }
        return result;
    }
}
