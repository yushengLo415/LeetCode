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
          public TreeNode(int x) { val = x; }
    }

    class Solution235
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == p || root == q)
                return root;

            if (p.val < root.val && q.val < root.val)
                root = LowestCommonAncestor(root.left, p, q);
            else if (p.val > root.val && q.val > root.val)
                root = LowestCommonAncestor(root.right, p, q);
           

            return root;
        }

        /*static int Main()
        {
            Solution235 sol = new Solution235();

            Console.ReadKey();
            return 0;
        }*/
    }
}
