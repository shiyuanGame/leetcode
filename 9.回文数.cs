/*
 * @lc app=leetcode.cn id=9 lang=csharp
 * @lcpr version=21909
 *
 * [9] 回文数
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        // 特殊情况：
        // 如上所述，当 x < 0 时，x 不是回文数。
        // 同样地，如果数字的最后一位是 0，为了使该数字为回文，
        // 则其第一位数字也应该是 0
        // 只有 0 满足这一属性
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int last = 0;
        while (last < x)
        {
            last = last * 10 + x % 10;
            x /= 10;
        }

        return last == x || x == (last /= 10);

    }

}

// @lc code=end



/*
// @lcpr case=start
// 121\n
// @lcpr case=end

// @lcpr case=start
// -121\n
// @lcpr case=end

// @lcpr case=start
// 10\n
// @lcpr case=end

 */

