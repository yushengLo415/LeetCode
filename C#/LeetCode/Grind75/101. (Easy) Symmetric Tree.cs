using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution101
    {
        public bool IsSymmetric(TreeNode root)
        {
            return CheckSymmetric(root.left, root.right);
        }

        public bool CheckSymmetric(TreeNode left, TreeNode right)
        {
            if (left != null && right != null)
                if (left.val != right.val)
                    return false;
                else
                    return CheckSymmetric(left.left, right.right) && CheckSymmetric(left.right, right.left);

            return (left == null) && (right == null);
        }
    }
}
