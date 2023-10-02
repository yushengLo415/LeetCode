using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution543
    {
        private int max = 0;
        public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            maxDepth(root);
            return max;
        }

        private int maxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = maxDepth(root.left);
            int right = maxDepth(root.right);
            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;
        }
    }
}
