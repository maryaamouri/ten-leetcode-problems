using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ten_leetcode_problems.TreeNode;
namespace ten_leetcode_problems
{
    internal static class BinaryTreeAllPaths
    {
        static internal TreeNode CreateSampleTreeNode()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));

            return root;
        }

        internal static IList<string> GetBinaryTreePths(TreeNode root)
        {
            IList<string> paths = new List<string>();
            string currentPath = root.val.ToString();
            if (root.left == null && root.right == null)
            {
                paths.Add(currentPath);
            }
            if (root.left != null)
                CreatePathsUsingDFS(
                    root: root.left,
                    currentPath,
                    paths);
            if (root.right != null)
                CreatePathsUsingDFS(
                    root: root.right,
                    currentPath,
                    paths);
            return paths;
        }
        static void CreatePathsUsingDFS(TreeNode root, string currentPath, IList<string> paths)
        {
            currentPath = $"{currentPath}->{root.val}";
            if (root.left == null && root.right == null)
            {
                paths.Add(currentPath);
                return;
            }
            if (root.left != null) CreatePathsUsingDFS(root.left, currentPath, paths);
            if (root.right != null) CreatePathsUsingDFS(root.right, currentPath, paths);

        }
    }
}
