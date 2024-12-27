// https://www.geeksforgeeks.org/write-c-code-to-determine-if-two-trees-are-identical/?ref=lbp
// https://leetcode.com/problems/same-tree/submissions/1489696695/
namespace IdenticalTrees;
class Node
{
    public int data;
    public Node? left;
    public Node? right;
    public Node(int data) => this.data = data;
}
class Tree
{
    public static bool IsSameTree(Node? p, Node? q)
    {
        if (p == null && q == null) return true;

        if(p is null || q is null) return false;

        return p?.data == q?.data 
                && IsSameTree(p?.left, q?.left)
                && IsSameTree(p?.right, q?.right);

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
        //      / 
        //     4   
        Node first = new Node(1)
        {
            left = new Node(2),
            right = new Node(3)
        };
        //first.left.left = new Node(4);

        // Representation of the input tree:
        //         1
        //        / \
        //       2   3
        //      / 
        //     4   
        Node second = new Node(1)
        {
            left = new Node(2),
            right = new Node(3)
        };
        //second.left.left = new Node(4);

        string identical = Tree.IsSameTree(first, second) ? "Identical":"Not Identical";
        System.Console.WriteLine($"The tree is {identical}");
    }
}

