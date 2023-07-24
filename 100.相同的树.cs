/*
 * @lc app=leetcode.cn id=100 lang=csharp
 * @lcpr version=21912
 *
 * [100] 相同的树
 */

// @lc code=start
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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return isAllRight(p, q);
    }
    bool isAllRight(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }
        else if ((p != null && q == null) || (p == null && q != null))
        {
            return false;
        }

        if (p.val == q.val)
        {
            return isAllRight(p.right, q.right) && isAllRight(p.left, q.left);
        }
        else
        {
            return false;
        }

    }
}
public class Solution2
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return isAllRight(p, q);
    }
    bool isAllRight(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
        {
            return true;
        }
        else if ((p != null && q == null) || (p == null && q != null))
        {
            return false;
        }

        if (p.val == q.val)
        {
            if (isAllRight(p.left, q.left))
            {
                return isAllRight(p.right, q.right);
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }

    }
}
// @lc code=end



/*
// @lcpr case=start
// [1,2,3]\n[1,2,3]\n
// @lcpr case=end

// @lcpr case=start
// [1,2]\n[1,null,2]\n
// @lcpr case=end

// @lcpr case=start
// [1,2,1]\n[1,1,2]\n
// @lcpr case=end

 */

