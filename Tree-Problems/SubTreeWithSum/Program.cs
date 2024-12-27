// https://www.geeksforgeeks.org/subtree-given-sum-binary-tree/?ref=lbp

namespace SubTreeWithSum;
class Node
{
    public int data;
    public Node? left;
    public Node? right;
    public Node(int data) => this.data = data;
}
class Tree
{
    public static int SubTreeSum(Node? root)
    {
        if (root == null) return 0;
        return root.data + SubTreeSum(root.left) + SubTreeSum(root.right);
    }
    public static bool SubTreeWithGivenSum(Node? root, int key)
    {
        if (root == null) return false;
        if (SubTreeSum(root.left) == key) return true;
        if (SubTreeSum(root.right) == key) return true;
        return SubTreeWithGivenSum(root.left, key) || SubTreeWithGivenSum(root.right, key);
    }
}
class Program
{
    public static void Main(string[] args)
    {
        // Representation of the input tree:
        //         1
        //        / \
        //       2   3
        //      / \
        //     4   5
        Node first = new Node(1)
        {
            left = new Node(2),
            right = new Node(3)
        };
        first.left.left = new Node(4);
        first.left.right = new Node(5);
        var result = Tree.SubTreeWithGivenSum(first, 15) ? "Matches": "Does Not";
        Console.WriteLine($"Given Tree {result} with the key");
        
    }
}