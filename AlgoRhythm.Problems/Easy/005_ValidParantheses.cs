namespace AlgoRhythm.Problems.Easy;

public class ValidParantheses {
    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();

        foreach (var bracket in s) {
            if (bracket == '(' || bracket == '{' || bracket == '[') {
                brackets.Push(bracket);
            } else {
                if (brackets.Count == 0) {
                    return false;
                }

                var match = brackets.Pop();
                if ((match == '(' && bracket != ')') || (match == '{' && bracket != '}') || (match == '[' && bracket != ']')) {
                    return false;
                }
            }
        }

        return brackets.Count() == 0;
    }
}
