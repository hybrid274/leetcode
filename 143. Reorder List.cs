public class Solution
{
    public void ReorderList(ListNode head)
    {
        if (head == null || head.next == null || head.next.next == null)
            return;
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        ListNode mid = slow.next;
        slow.next = null;
        ListNode last = mid, pre = null;
        while (last != null)
        {
            ListNode next = last.next;
            last.next = pre;
            pre = last;
            last = next;
        }
        while (head != null && pre != null)
        {
            ListNode next = head.next;
            head.next = pre;
            pre = pre.next;
            head.next.next = next;
            head = next;
        }
    }
}
