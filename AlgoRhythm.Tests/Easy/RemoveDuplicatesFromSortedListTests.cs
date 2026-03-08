using AlgoRhythm.Problems.Easy;

namespace AlgoRhythm.Tests.Easy;

public class RemoveDuplicatesFromSortedListTests {
    private RemoveDuplicatesFromSortedList.ListNode BuildList(int[] values) {
        if (values.Length == 0) return null;

        var head = new RemoveDuplicatesFromSortedList.ListNode(values[0]);
        var current = head;

        for (int i = 1; i < values.Length; i++) {
            current.next = new RemoveDuplicatesFromSortedList.ListNode(values[i]);
            current = current.next;
        }

        return head;
    }

    // Helper: linked list -> array
    private int[] ToArray(RemoveDuplicatesFromSortedList.ListNode head) {
        var list = new List<int>();
        var current = head;

        while (current != null) {
            list.Add(current.val);
            current = current.next;
        }

        return list.ToArray();
    }

    [Fact]
    public void Example1_ReturnsCorrectResult() {
        var solver = new RemoveDuplicatesFromSortedList();
        var head = BuildList([1, 1, 2]);
        var result = solver.Solve(head);
        Assert.Equal([1, 2], ToArray(result));
    }

    [Fact]
    public void Example2_ReturnsCorrectResult() {
        var solver = new RemoveDuplicatesFromSortedList();
        var head = BuildList([1, 1, 2, 3, 3]);
        var result = solver.Solve(head);
        Assert.Equal([1, 2, 3], ToArray(result));
    }
}
