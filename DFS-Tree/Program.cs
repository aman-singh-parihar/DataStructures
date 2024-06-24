namespace DFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                      1
                   /     \
                  2       3
                 / \     / \
                4   5   6   7 
               /       / \
              8       9   10
                    
                                     
            */
            TreeNode root = new(1); 
            root.left = new(2);
            root.right = new(3);

            root.left.left = new(4);
            root.left.right = new(5);

            root.left.left.left = new(8);

            root.right.left = new(6);
            root.right.right = new(7);

            root.right.left.left = new(9);
            root.right.left.right = new(10);
            TreeNode.InorderTraversal(root);
        }
    }
    internal class TreeNode 
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        internal TreeNode(int val)
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }
        internal static void InorderTraversal(TreeNode node) 
        {
            if (node == null) 
            {
                return;
            }
            InorderTraversal(node.left);
            Console.WriteLine(node.val);
            InorderTraversal(node.right);
        }
    }
}
