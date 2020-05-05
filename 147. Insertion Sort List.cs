public class Solution
{
    public ListNode InsertionSortList(ListNode head)
    {
        ListNode dummy = new ListNode(-1);
        ListNode cur = dummy;
        while (head != null)
        {
            ListNode t = head.next;
            cur = dummy;
            while (cur.next != null && cur.next.val <= head.val)
            {
                cur = cur.next;
            }
            head.next = cur.next;
            cur.next = head;
            head = t;
        }
        return dummy.next;
    }
}
