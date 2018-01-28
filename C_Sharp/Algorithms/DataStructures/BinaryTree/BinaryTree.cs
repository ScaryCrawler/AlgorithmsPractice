namespace DataStructures.BinaryTree
{
    public class BinaryTree
    {
        public class Tree {
            public static TreeNode InvertTree(TreeNode root)
            {
                var tmp = root.Right;
                root.Right = root.Left;
                root.Left = root.Right;

                InvertTree(root.Left);
                InvertTree(root.Right);
                return root;
            }
        }

        public class TreeNode
        {
            public int Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }
        }
    }
}