using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Solution226
    {
 
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
 
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;
            if (root.left != null)
                InvertTree(root.left);
            if (root.right != null)
                InvertTree(root.right);

            TreeNode dummy = new TreeNode();
            dummy = root.left;
            root.left = root.right;
            root.right = dummy;

            return root;
        }


        /*static int Main()
        {
            Solution226 sol = new Solution226();
            TreeNode t1 = new TreeNode(1);
            TreeNode t2 = new TreeNode(3);
            TreeNode t3 = new TreeNode(2, t1, t2);
            TreeNode t4 = new TreeNode(6);
            TreeNode t5 = new TreeNode(9);
            TreeNode t6 = new TreeNode(7, t4, t5);
            TreeNode t7 = new TreeNode(4, t3, t6);

            Console.WriteLine(sol.InvertTree(t7).val);
            Console.ReadKey();
            return 0;
        }*/
    }
}
