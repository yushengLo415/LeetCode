using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution110
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            return ToTheDeep(root) != -1;
        }

        public int ToTheDeep(TreeNode root)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (root == null)
                return 0;

            leftHeight = ToTheDeep(root.left);
            rightHeight = ToTheDeep(root.right);

            if (Math.Abs(leftHeight - rightHeight) > 1 || leftHeight == -1 || rightHeight == -1)
                return -1;

            return leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;
        }
    }
}
