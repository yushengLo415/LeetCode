using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    public class Solution572
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {

            if (root == null)
                return false;

            if (root.val == subRoot.val && CheckDFS(root, subRoot))
                return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        public bool CheckDFS(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null)
                return true;

            if (root == null || subRoot == null || root.val != subRoot.val)
                return false;

            return CheckDFS(root.left, subRoot.left) && CheckDFS(root.right, subRoot.right);

        }
    }
}
