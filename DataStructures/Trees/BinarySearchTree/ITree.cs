namespace DataStructures.Trees.BinarySearchTree;

internal interface ITree<T>
{
    void Insert(T element);

    void Delete();

    TreeNode<T>? Find(T element);

    TreeNode<T>? GetMaximumNode();

    TreeNode<T>? GetMinimumNode();

    TreeNode<T>? GetPredecessor(T element);

    TreeNode<T>? GetSuccessor(T element);

    List<T> Inorder();

    List<T> Preorder();

    List<T> Postorder();
}

