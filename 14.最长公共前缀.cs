/*
 * @lc app=leetcode.cn id=14 lang=csharp
 * @lcpr version=21909
 *
 * [14] 最长公共前缀
 */
using System;
// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        // if (strs == null || strs.Length == 0) return null;

        // string first = strs[0];
        // for (var i = 1; i < strs.Length; i++)
        // {
        //     for (var index = 0; index < first.Length; index++)
        //     {
        //         if (!strs[index].StartsWith(first))
        //         {
        //             if (first.Length > 0)
        //             {
        //                 first = first.Remove(first.Length - 1, 1);
        //                 Console.WriteLine(first);

        //             }
        //             else
        //                 return "";
        //         }
        //     }
        // }

        // return first;

        if (strs == null || strs.Length == 0) return null;

        var first = strs[0];
        // string result = "";
        for (var index = 1; index < strs.Length; index++)
        {
            first = startStr(first, strs[index]);

            if (first.Length <= 0)
            {
                break;
            }
        }
        return first;
    }


    public static string startStr(string str1, string str2)
    {
        var length = Math.Min(str1.Length, str2.Length);

        var index = 0;
        while (index < length && str1.ToCharArray(0, index) == str2.ToCharArray(0, index))
        {
            index++;
        }
        return str1.Substring(0, index);

    }
}

class Solution2
{
    public string longestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.length == 0)
        {
            return "";
        }
        string prefix = strs[0];
        int count = strs.length;
        for (int i = 1; i < count; i++)
        {
            prefix = longestCommonPrefix(prefix, strs[i]);
            if (prefix.length() == 0)
            {
                break;
            }
        }
        return prefix;
    }

    public string longestCommonPrefix(string str1, string str2)
    {
        int length = Math.min(str1.length(), str2.length());
        int index = 0;
        while (index < length && str1.charAt(index) == str2.charAt(index))
        {
            index++;
        }
        return str1.substring(0, index);
    }
}
class Solution3
{
    public String longestCommonPrefix(String[] strs)
    {
        if (strs == null || strs.length == 0)
        {
            return "";
        }
        else
        {
            return longestCommonPrefix(strs, 0, strs.length - 1);
        }
    }

    public String longestCommonPrefix(String[] strs, int start, int end)
    {
        if (start == end)
        {
            return strs[start];
        }
        else
        {
            int mid = (end - start) / 2 + start;
            String lcpLeft = longestCommonPrefix(strs, start, mid);
            String lcpRight = longestCommonPrefix(strs, mid + 1, end);
            return commonPrefix(lcpLeft, lcpRight);
        }
    }

    public String commonPrefix(String lcpLeft, String lcpRight)
    {
        int minLength = Math.min(lcpLeft.length(), lcpRight.length());
        for (int i = 0; i < minLength; i++)
        {
            if (lcpLeft.charAt(i) != lcpRight.charAt(i))
            {
                return lcpLeft.substring(0, i);
            }
        }
        return lcpLeft.substring(0, minLength);
    }
}




// @lc code=end



/*
// @lcpr case=start
// ["flower","flow","flight"]\n
// @lcpr case=end

// @lcpr case=start
// ["dog","racecar","car"]\n
// @lcpr case=end

 */

