/*
 * @lc app=leetcode.cn id=94 lang=csharp
 * @lcpr version=21912
 *
 * [94] 二叉树的中序遍历
 */

// @lc code=start

// Definition for a binary tree node.
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
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> tempValue = new List<int>();
        test(root, tempValue);
        return tempValue;
    }

    void test(TreeNode root, List<int> tempValue)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        while (root != null || stack.Count > 0)
        {

            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();

            tempValue.Add(root.val);

            root = root.right;

        }


    }


}
// public class Solution2
// {
//     public IList<int> InorderTraversal(TreeNode root)
//     {
//         List<int> tempValue = new List<int>();
//         test(root, tempValue);
//         return tempValue;
//     }

//     void test(TreeNode root, List<int> tempValue)
//     {
//         if (root != null)
//         {
//             tempValue.Add(root.val);
//             test(root.left, tempValue);
//             test(root.right, tempValue);
//         }

//     }


// }
// @lc code=end



/*
// @lcpr case=start
// [1,null,2,3]\n
// @lcpr case=end

// @lcpr case=start
// []\n
// @lcpr case=end

// @lcpr case=start
// [1]\n
// @lcpr case=end

 */

