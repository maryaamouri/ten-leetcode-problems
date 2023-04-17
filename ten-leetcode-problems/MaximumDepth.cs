using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal class MaximumDepth
    {
       
            public int Get(TreeNode root)
            {
                return dfs(root);
            }
            private int dfs(TreeNode root, int depth = 0)
            {
                if (root == null) return 0;
                return max(dfs(root.left, depth) + 1, dfs(root.right, depth) + 1);
            }
            private int max(int x, int y) { if (x > y) return x; else return y; }

        }
    }

