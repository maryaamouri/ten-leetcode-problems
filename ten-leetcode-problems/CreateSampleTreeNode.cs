using System;

public class CreateSampleTreeNode
{
    static internal TreeNode CreateSampleTreeNode()
    {
        var root = new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3));

        return root;
    }
}
