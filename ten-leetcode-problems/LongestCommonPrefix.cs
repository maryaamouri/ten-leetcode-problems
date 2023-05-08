using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal static class LongestCommonPrefix
    {
        public static string GetLongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];
            foreach (string str in strs)
            {
                while ((prefix.Length > 0) && str.StartsWith(prefix) == false)
                {

                    prefix = prefix.Remove(prefix.Length - 1);
                   
                }

            }
            return prefix;
        }
    }
}
