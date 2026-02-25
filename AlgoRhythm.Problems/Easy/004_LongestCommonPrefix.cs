namespace AlgoRhythm.Problems.Easy;

public class LongestCommonPrefix {
    public string Solve(string[] strs) {
        if (strs == null || strs.Length == 0)
            return "";

        var prefix = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            while (!strs[i].StartsWith(prefix)) {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == "")
                    return "";
            }
        }

        return prefix;
    }
}
