public class Solution
{
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode dummy = new ListNode(-1);
        ListNode pre = dummy;
        dummy.next = head;
        while (pre.next != null)
        {
            if (pre.next.val == val)
            {
                ListNode temp = pre.next;
                pre.next = temp.next;
                temp.next = null;
            }
            else
                pre = pre.next;
        }
        return dummy.next;
    }
}
