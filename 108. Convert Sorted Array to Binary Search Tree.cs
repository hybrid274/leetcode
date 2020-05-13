public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return DFS(nums, 0, nums.Length - 1);
    }

    private TreeNode DFS(int[] nums, int left, int right)
    {
        if (left > right)
            return null;
        int mid = left + (right - left) / 2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = DFS(nums, left, mid - 1);
        root.right = DFS(nums, mid + 1, right);
        return root;
    }
}
