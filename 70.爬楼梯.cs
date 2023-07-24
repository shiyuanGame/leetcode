/*
 * @lc app=leetcode.cn id=70 lang=csharp
 * @lcpr version=21912
 *
 * [70] 爬楼梯
 */

// @lc code=start
public class Solution
{
    public int ClimbStairs(int n)
    {
        return sum(n);
    }
    public int sum(int n)
    {
        if (n == 1) return 1;

        int first = 1;
        int value = 2;

        for (var i = 3; i <= n; i++)
        {
            int tempValue = first + value;
            first = value;
            value = tempValue;

        }
        return value;
    }
}
// public class Solution2
// {
//     public int ClimbStairs(int n)
//     {
//         return sum(n);
//     }
//     public int sum(int n)
//     {
//         if (n == 1) return 1;

//         int[] saver = new int[n + 1];
//         saver[1] = 1;
//         saver[2] = 2;
//         for (var i = 3; i < saver.Length; i++)
//         {
//             saver[i] = saver[i - 1] + saver[i - 2];
//         }
//         return saver[n];
//     }
// }

// public class Solution3
// {
//     public int ClimbStairs(int n)
//     {
//         return sum(n, saver);
//     }
//     public int sum(int n)
//     {
//         if (n == 1) return 1;

//         int[] saver = new int[n + 1];
//         saver[0] = 1;
//         saver[1] = 2;
//         int tempValue = 0;
//         for (var i = 2; i < saver.Length; i++)
//         {
//             saver[i] = saver[i - 1] + saver[i - 2];
//         }
//         return saver[n];
//     }
// }
// @lc code=end



/*
// @lcpr case=start
// 2\n
// @lcpr case=end

// @lcpr case=start
// 3\n
// @lcpr case=end

 */

