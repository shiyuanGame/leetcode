/*
 * @lc app=leetcode.cn id=13 lang=csharp
 * @lcpr version=21909
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
using System;
using System.Collections.Generic;

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        dic.Add('I', 1);
        dic.Add('V', 5);

        dic.Add('X', 10);

        dic.Add('L', 50);
        dic.Add('C', 100);
        dic.Add('D', 500);
        dic.Add('M', 1000);
        if (s == null || s.Length == 0) return 0;

        int result = 0;
        for (var index = 0; index < s.Length; index++)
        {
            int currentValue = dic[s[index]];
            if ((index + 1) < s.Length && currentValue < dic[s[index + 1]])
            {
                result -= currentValue;
            }
            else
            {
                result += currentValue;
            }
        }
        return result;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "III"\n
// @lcpr case=end

// @lcpr case=start
// "IV"\n
// @lcpr case=end

// @lcpr case=start
// "IX"\n
// @lcpr case=end

// @lcpr case=start
// "LVIII"\n
// @lcpr case=end

// @lcpr case=start
// "MCMXCIV"\n
// @lcpr case=end

 */

