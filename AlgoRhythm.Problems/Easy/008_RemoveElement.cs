namespace AlgoRhythm.Problems.Easy;

public class RemoveElement {
    public int Solve(int[] nums, int val) {
        // Given an integer array nums and an integer val, remove all
        // occurrences of val in nums in-place. The order of the elements
        // may be changed. Then return the number of elements in nums which
        // are not equal to val.

        // [3,2,2,3] val =3 , output = 2
        // [0,1,2,2,3,0,4,2] val = 2, output = 5 [0,1,4,0,3]

        if (nums.Length == 0) return 0;
        int j = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}
