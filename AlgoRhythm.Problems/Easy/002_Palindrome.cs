namespace AlgoRhythm.Problems.Easy;

public class Palindrome {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }

        var stringX = x.ToString();
        int left = 0;
        int right = stringX.Length - 1;

        while (left < right) {
            if (stringX[left] != stringX[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
