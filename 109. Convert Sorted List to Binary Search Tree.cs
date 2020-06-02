public class Solution
{
    public TreeNode SortedListToBST(ListNode head)
    {
        int n = GetLangth(head);
        return DFS(head, 0, n - 1);
    }

    private TreeNode DFS(ListNode head, int left, int right)
    {
        if (left > right)
            return null;
        if (head == null)
            return null;
        int mid = left + (right - left) / 2;
        ListNode midNode = GetNode(head, mid - left);
        TreeNode cur = new TreeNode(midNode.val);
        ListNode leftNode = head;
        ListNode rightNode = midNode.next;
        cur.left = DFS(leftNode, left, mid - 1);
        cur.right = DFS(rightNode, mid + 1, right);
        return cur;
    }

    private ListNode GetNode(ListNode head, int count)
    {
        ListNode res = head;
        while (count > 0)
        {
            res = res.next;
            count--;
        }
        return res;
    }

    private int GetLangth(ListNode head)
    {
        int res = 0;
        while (head != null)
        {
            head = head.next;
            res++;
        }
        return res;
    }
}
