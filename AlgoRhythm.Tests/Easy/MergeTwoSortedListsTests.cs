using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class MergeTwoSortedListsTest {

    private MergeTwoSortedLists.ListNode BuildList(int[] values) {
        if (values.Length == 0) return null;

        var head = new MergeTwoSortedLists.ListNode(values[0]);
        var current = head;

        for (int i = 1; i < values.Length; i++) {
            current.next = new MergeTwoSortedLists.ListNode(values[i]);
            current = current.next;
        }

        return head;
    }

    private int[] ToArray(MergeTwoSortedLists.ListNode head) {
        var result = new List<int>();
        while (head != null) {
            result.Add(head.val);
            head = head.next;
        }
        return result.ToArray();
    }

    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new MergeTwoSortedLists();

        var list1 = BuildList(new[] { 1, 2, 4 });
        var list2 = BuildList(new[] { 1, 3, 4 });

        var result = solver.Solve(list1, list2);

        Assert.Equal(new[] { 1, 1, 2, 3, 4, 4 }, ToArray(result));
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new MergeTwoSortedLists();

        var result = solver.Solve(null, null);

        Assert.Null(result);
    }

    [Fact]
    public void Example3_ReturnsCorrectResult() {
        var solver = new MergeTwoSortedLists();

        var list2 = BuildList(new[] { 0 });

        var result = solver.Solve(null, list2);

        Assert.Equal(new[] { 0 }, ToArray(result));
    }
}
