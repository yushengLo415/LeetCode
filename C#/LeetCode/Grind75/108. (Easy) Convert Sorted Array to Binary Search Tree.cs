using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution108
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {

            return ConstructRecursive(nums, 0, nums.Length - 1);
        }

        public TreeNode ConstructRecursive(int[] nums, int start, int end)
        {
            if (start > end)
                return null;
            int mid = start + (end - start) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = ConstructRecursive(nums, start, mid - 1);
            root.right = ConstructRecursive(nums, mid + 1, end);

            return root;
        }
    }
}
