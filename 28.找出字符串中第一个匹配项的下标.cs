/*
 * @lc app=leetcode.cn id=28 lang=csharp
 * @lcpr version=21912
 *
 * [28] 找出字符串中第一个匹配项的下标
 */

// @lc code=start
public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int n = haystack.Length;
        int index = 0;
        while (index < n)
        {
            if (haystack[index] == needle[0] && (index + needle.Length) <= n)
            {
                bool isRight = true;
                for (var i = 1; i < needle.Length; i++)
                {
                    if (haystack[index + i] != needle[i])
                    {
                        isRight = false;
                        break;
                    }
                }
                if (isRight) return index;
            }
            index++;
        }
        return -1;
    }
}
// @lc code=end



/*
// @lcpr case=start
// "sadbutsad"\n"sad"\n
// @lcpr case=end

// @lcpr case=start
// "leetcode"\n"leeto"\n
// @lcpr case=end

 */

