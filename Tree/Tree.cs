namespace DataStructures.Tree;
class Node
{
    public int data;
    public Node? left;
    public Node? right;
    public Node(int data) => this.data = data;
}
class Tree
{
    /*
    Level Order Traversal using Queue
    */
    public static void LevelOrderTraversal(Node root)
    {
        var list = new List<int>();
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var temp = queue.FirstOrDefault();
            if(temp?.left != null)
            {
                queue.Enqueue(temp.left);
            }
            if(temp?.right != null)
            {
                queue.Enqueue(temp.right);
            }
            list.Add(queue.Dequeue().data);
        }
        foreach (var item in list)
        {
            System.Console.WriteLine(item);
        }
    }
    /*
    To check if the tree is heigh balanced.
    Difference between the left and right tree should not be more than 1.
    */
    public static bool IsHeightBalancedTree(Node node)
    {
        var left = HeightOfSubTree(node.left!);
        var right = HeightOfSubTree(node.right!);
        return int.Abs(right - left) <= 1;
    }
    /*
    Heigh of the tree
    */
    public static int HeightOfTree(Node node)
    {
        if (node == null) return -1;
        return int.Max(HeightOfTree(node.left!),  HeightOfTree(node.right!)) + 1;
    }
    public static int HeightOfSubTree(Node node)
    {
        if(node == null) return -1;
        var leftHeight = HeightOfSubTree(node.left!);
        var rightHeight = HeightOfSubTree(node.right!);
        return int.Max(leftHeight,rightHeight) + 1;
    }
    public static void Main(string[] args)
    {

        // Representation of the input tree:
        //         1
        //        / \
        //       2   3
        //      / \
        //     4   5
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);

        Console.WriteLine(HeightOfTree(root));
        Console.WriteLine(IsHeightBalancedTree(root));
        LevelOrderTraversal(root);
    }


}