public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null)
            return null;
        int lenA = GetNodeLenght(headA);
        int lenB = GetNodeLenght(headB);
        if (lenA < lenB)
        {
            for (int i = 0; i < lenB - lenA; i++)
                headB = headB.next;
        }
        else
        {
            for (int i = 0; i < lenA - lenB; i++)
                headA = headA.next;
        }

        while (headA != null && headB != null && headA != headB)
        {
            headA = headA.next;
            headB = headB.next;
        }
        return (headA != null && headB != null) ? headA : null;
    }

    private int GetNodeLenght(ListNode head)
    {
        int cnt = 0;
        while (head != null)
        {
            cnt++;
            head = head.next;
        }
        return cnt;
    }
}
