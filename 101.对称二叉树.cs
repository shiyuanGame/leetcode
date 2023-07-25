/*
 * @lc app=leetcode.cn id=101 lang=csharp
 * @lcpr version=21912
 *
 * [101] 对称二叉树
 */

// @lc code=start

//  Definition for a binary tree node.
using System.Collections.Generic;

// public class TreeNode
// {
//     public int val;
//     public TreeNode left;
//     public TreeNode right;
//     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
//     {
//         this.val = val;
//         this.left = left;
//         this.right = right;
//     }
// }

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {

        return isLike(root.left, root.right);

    }
    bool isLike(TreeNode left, TreeNode right)
    {

        Stack<TreeNode> stack = new Stack<TreeNode>();

        stack.Push(left);
        stack.Push(right);

        while (stack.Count > 0)
        {
            var tempLeft = stack.Pop();
            var tempRight = stack.Pop();

            if (tempLeft == null && tempRight == null)
            {
                continue;
            }
            if (tempLeft == null || tempRight == null)
            {
                return false;
            }
            if (tempLeft.val != tempRight.val)
            {
                return false;
            }

            stack.Push(tempLeft.left);
            stack.Push(tempRight.right);

            stack.Push(tempLeft.right);
            stack.Push(tempRight.left);

        }
        return true;
    }
}
// public class Solution2
// {
//     public bool IsSymmetric(TreeNode root)
//     {

//         return isLike(root.left, root.right);

//     }
//     bool isLike(TreeNode left, TreeNode right)
//     {
//         if (left == null && right == null)
//         {
//             return true;
//         }
//         else if (left == null || right == null)
//         {
//             return false;
//         }
//         else if (left.val != right.val)
//         {
//             return false;
//         }
//         else
//         {
//             return isLike(left.left, right.right) && isLike(left.right, right.left);
//         }
//     }
// }

// @lc code=end



/*
// @lcpr case=start
// [1,2,2,3,4,4,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,2,null,3,null,3]\n
// @lcpr case=end

 */

