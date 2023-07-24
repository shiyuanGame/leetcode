/*
 * @lc app=leetcode.cn id=69 lang=csharp
 * @lcpr version=21912
 *
 * [69] x 的平方根 
 */

// @lc code=start
using System;

public class Solution
{
    public int MySqrt(int x)
    {
        int l = 0, r = x, ans = -1;

        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if ((long)mid * mid <= x)
            {
                ans = mid;
                l = mid + 1;
            }
            else
            {


                r = mid - 1;
            }
        }
        return ans;
    }
}


// 作者：LeetCode-Solution
// 链接：https://leetcode.cn/problems/sqrtx/solution/x-de-ping-fang-gen-by-leetcode-solution/
// 来源：力扣（LeetCode）
// 著作权归作者所有。商业转载请联系作者获得授权，非商业转载请注明出处。

// @lc code=end



/*
// @lcpr case=start
// 4\n
// @lcpr case=end

// @lcpr case=start
// 8\n
// @lcpr case=end

 */

