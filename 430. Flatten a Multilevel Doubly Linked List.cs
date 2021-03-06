public class Solution
{
    public Node Flatten(Node head)
    {
        if (head == null) return null;
        DFS(head);
        return head;
    }

    private Node DFS(Node head)
    {
        var cur = head;
        while (cur != null && cur.child == null)
            cur = cur.child;
        if (cur != null)
        {
            var next = cur.next;
            var childHead = DFS(cur.child);
            cur.child = null;
            cur.next = childHead;
            childHead.prev = cur;

            var curChild = childHead;
            while (curChild.next != null)
                curChild = curChild.next;
            curChild.next = next;
            if (next != null)
                next.prev = curChild;
            DFS(next);
        }
        return head;
    }
}
