using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Grind75
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
    class Solution102 : Solution
    {
        public override int RunScript()
        {
            return 0;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            Queue<TreeNode> childList = new Queue<TreeNode>();
            childList.Enqueue(root);

            while (childList.Count > 0)
            {

                int count = childList.Count;
                List<int> levelValue = new List<int>();

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = childList.Dequeue();
                    levelValue.Add(node.val);

                    if (node.left != null)
                        childList.Enqueue(node.left);
                    if (node.right != null)
                        childList.Enqueue(node.right);
                }

                result.Add(levelValue);
            }

            return result;
        }
    }
}
