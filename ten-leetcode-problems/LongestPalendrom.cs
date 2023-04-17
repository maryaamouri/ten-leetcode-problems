using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal static class LongestPalendrom
    {
        public static int GetLongestPalindrome(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (!dic.ContainsKey(ch))
                    dic.Add(ch, 1);
                else
                    dic[ch]++;
            }
            bool containsOddFreq = false;
            int longestPalendrom = 0;
            foreach (var key in dic.Keys)
            {
                if (dic[key] % 2 == 1)
                {
                    containsOddFreq = true;
                    dic[key]--;
                }
                longestPalendrom += dic[key];


            }
            if (containsOddFreq)
                longestPalendrom++;
            return longestPalendrom;

        }
    }
}
