using System;

public class CreateSampleTree
{
    static internal TreeNode CreateSampleTreeNode()
    {
        TreeNode root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));

        return root;
    }
}
