namespace AlgoRhythm.Problems.Easy;

public class MergeTwoSortedLists {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode Solve(ListNode list1, ListNode list2) {
        if (list1 == null) return list2;

        if (list2 == null) return list1;

        var newListNode = new ListNode();
        var current = newListNode;

        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                current.next = list1;
                list1 = list1.next;     // attach the current node that list1 is pointing to 
            } else {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }
        current.next = list1 ?? list2;  // Whatever is left, attach it to the next one

        return newListNode.next;
    }
}
