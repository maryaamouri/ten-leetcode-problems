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
                return Math.Max(Get(root.left, depth) + 1, Get(root.right, depth) + 1);
            }
        static internal TreeNode CreateSampleTreeNode()
        {
            var root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));

            return root;
        }


    }
    }

