/*
 * @lc app=leetcode.cn id=58 lang=csharp
 * @lcpr version=21912
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var index = s.Length - 1;

        while (s[index] == ' ')
        {
            index--;
        }
        var startindex = 0;
        while (index >= 0 && s[index] != ' ')
        {
            index--;
            startindex++;
        }
        return startindex;
    }
}
public class Solution2
{
    public int LengthOfLastWord(string s)
    {
        var strs = s.Split(" ");
        int last = strs.Length - 1;
        while (strs[last].Length == 0)
        {
            last--;
        }
        return strs[last].Length;

    }
}
// @lc code=end



/*
// @lcpr case=start
// "Hello World"\n
// @lcpr case=end

// @lcpr case=start
// "   fly me   to   the moon  "\n
// @lcpr case=end

// @lcpr case=start
// "luffy is still joyboy"\n
// @lcpr case=end

 */

