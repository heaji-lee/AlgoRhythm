using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class MergeSortedArrayTests {
    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new MergeSortedArray();
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        int[] nums2 = [2, 5, 6];

        solver.Solve(nums1, 3, nums2, 3);
        Assert.Equal([1, 2, 2, 3, 5, 6], nums1);
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new MergeSortedArray();
        int[] nums1 = [1];
        int[] nums2 = [];

        solver.Solve(nums1, 1, nums2, 0);
        Assert.Equal([1], nums1);
    }

    [Fact]
    public void Example3_ReturnsCorrectResult() {
        var solver = new MergeSortedArray();
        int[] nums1 = [0];
        int[] nums2 = [1];

        solver.Solve(nums1, 0, nums2, 1);
        Assert.Equal([1], nums1);
    }
}
