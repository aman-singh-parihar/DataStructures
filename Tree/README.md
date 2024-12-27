## Tree Traversal

Tree traversal/Search is a process of visiting each node of a tree. During tree traversal, visit each node of a tree exactly once and perform an operation on the nodes like checking the node data or updating the node. 

Tree traversal algorithms can be classified broadly in the following two categories by the order in which the nodes are visited:

### Depth-first search (DFS) algorithm: 
It starts with the root node and first visits all nodes of one branch as deep as possible before backtracking. There are three subtypes under DFS.
- #### Inorder traversal:
Visits all nodes inside the left subtree, then visits the current node before visiting any node within the right subtree.

- #### Preorder traversal:
Visits the current node before visiting any nodes inside left or right subtrees.

- #### Postorder traversal:
Visits the current node after visiting all the nodes of left and right subtrees.

### Breadth-first search (BFS) algorithm: 
This also starts from the root node and visits all nodes of current depth before moving to the next depth in the tree.

- #### Level order traversal:
Visits nodes level-by-level and in left-to-right fashion at the same level.
