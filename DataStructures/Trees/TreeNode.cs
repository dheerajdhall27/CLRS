namespace DataStructures.Trees;

internal class TreeNode<T>
{
    public TreeNode<T>? Parent { get; set; }

    public TreeNode<T>? Left { get; set; }

    public TreeNode<T>? Right { get; set; }

    public T? Data { get; set; }

    public TreeNode(T data)
    {
        Parent = null;
        Left = null;
        Right = null;

        Data = data;
    }
}

