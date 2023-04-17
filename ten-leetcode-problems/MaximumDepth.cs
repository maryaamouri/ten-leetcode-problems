using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ten_leetcode_problems
{
    internal  class MaximumDepth
    {
       
            public static int  Get(TreeNode root, int depth = 0)
            {
                if (root == null) return 0;
                return max(Get(root.left, depth) + 1, Get(root.right, depth) + 1);
            }
            private static int max(int x, int y) {
            if (x > y) return x; else return y;
        }
        static internal TreeNode CreateSampleTreeNode()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));

            return root;
        }


    }
    }

