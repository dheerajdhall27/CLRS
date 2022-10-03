using DataStructures.ElementaryDataStructures;

namespace DataStructures.Trees.BinarySearchTree;

internal class BinarySearchTree<T> : ITree<T>
{
    private TreeNode<T>? _root;

    public BinarySearchTree()
    {
        _root = null;
    }

    public void Insert(T element)
    {
        if(element == null)
        {
            throw new ArgumentNullException(nameof(element));
        }

        TreeNode<T> node = new TreeNode<T>(element);

        if(_root == null)
        {
            _root = node;
            return;
        }

        TreeNode<T>? previous = null;

        TreeNode<T>? root = _root;

        Comparer<T> comparer = Comparer<T>.Default;

        while(root != null)
        {
            previous = root;

            int comparisonInt = comparer.Compare(root.Data, element);

            if(comparisonInt < 0)
            {
                root = root.Right;
            }
            else
            {
                root = root.Left;
            }
        }

        node.Parent = previous;

        int nodeComparison = comparer.Compare(node.Data, previous.Data);

        if(nodeComparison > 0)
        {
            previous.Right = node;
        }
        else
        {
            previous.Left = node;
        }
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    #region Inorder Traversal

    public List<T> Inorder()
    {
        if (_root == null)
        {
            return new List<T>();
        }

        TreeNode<T> root = _root;

        List<T> list = new List<T>();

        Inorder(root, list);

        return list;
    }

    private List<T> Inorder(TreeNode<T> root, List<T> list)
    {
        if(root == null)
        {
            return list;
        }

        list = Inorder(root.Left, list);
        list.Add(root.Data);
        list = Inorder(root.Right, list);

        return list;
    }

    private List<T> InorderIterative()
    {
        List<T> list = new List<T>();

        var root = _root;

        var stack = new StackCustom<TreeNode<T>>();

        stack.Push(root);

        AddLeftBranchOfNode(stack,ref root);

        while(root == null && stack.Size() > 0)
        {
            var node = stack.Pop();

            list.Add(node.Data);

            root = node.Right;
            if(root != null)
            {
                stack.Push(node.Right);
            }

            AddLeftBranchOfNode(stack,ref root);
        }

        return list;
    }

    private void AddLeftBranchOfNode(StackCustom<TreeNode<T>> stack, ref TreeNode<T> root)
    {
        if(root == null)
        {
            return;
        }

        while(root.Left != null)
        {
            stack.Push(root.Left);

            root = root.Left;
        }

        root = root.Left;
    }

    #endregion Inorder Traversal

    #region Preorder Traversal

    public List<T> Preorder()
    {
        if (_root == null)
        {
            return new List<T>();
        }

        TreeNode<T> root = _root;

        List<T> list = new List<T>();

        Preorder(root, list);

        return list;
    }

    private List<T> Preorder(TreeNode<T> root, List<T> list)
    {
        if (root == null)
        {
            return list;
        }

        list.Add(root.Data);
        list = Preorder(root.Left, list);
        list = Preorder(root.Right, list);

        return list;
    }

    private List<T> PreorderIterative()
    {
        var stack = new StackCustom<TreeNode<T>>();

        var root = _root;

        stack.Push(root);

        var list = new List<T>();

        while (stack.Size() > 0)
        {
            var item = stack.Pop();

            list.Add(item.Data);

            if(item.Right != null)
            {
                stack.Push(item.Right);
            }

            if(item.Left != null)
            {
                stack.Push(item.Left);
            }
        }

        return list;
    }

    #endregion

    #region Postorder Traversal

    public List<T> Postorder()
    {
        if (_root == null)
        {
            return new List<T>();
        }

        TreeNode<T> root = _root;

        List<T> list = new List<T>();

        Postorder(root, list);

        return list;
    }

    private List<T> Postorder(TreeNode<T> root, List<T> list)
    {
        if (root == null)
        {
            return list;
        }

        list = Postorder(root.Left, list);
        list = Postorder(root.Right, list);
        list.Add(root.Data);

        return list;
    }

    private List<T> PostorderIterative()
    {
        var list = new List<T>();

        var stack = new StackCustom<TreeNode<T>>();

        var root = _root;

        stack.Push(root);

        var stack2 = new StackCustom<TreeNode<T>>();

        while(stack.Size() > 0)
        {
            var element = stack.Pop();

            stack2.Push(element);

            if (element.Left != null)
            {
                stack.Push(element.Left);
            }

            if(element.Right != null)
            {
                stack.Push(element.Right);
            }
        }

        while(stack2.Size() > 0)
        {
            var node = stack2.Pop();

            list.Add(node.Data);
        }

        return list;
    }

    #endregion

    public TreeNode<T>? Find(T element)
    {
        if(_root == null)
        {
            return _root;
        }

        var root = _root;

        var equalityComparer = EqualityComparer<T>.Default;

        while(root != null)
        {
            if(equalityComparer.Equals(root.Data, element))
            {
                return root;
            }

            var comparer = Comparer<T>.Default;

            int comparisonInt = comparer.Compare(root.Data, element);

            // root is less element
            if(comparisonInt < 0)
            {
                root = root.Right;
            }
            else
            {
                root = root.Left;
            }
        }

        return null;
    }

    public TreeNode<T>? GetMaximumNode()
    {
        if(_root == null)
        {
            return null;
        }

        var root = _root;

        while(root.Right != null)
        {
            root = root.Right;
        }

        return root;
    }

    public TreeNode<T>? GetMinimumNode()
    {
        if (_root == null)
        {
            return null;
        }

        var root = _root;

        while (root.Left != null)
        {
            root = root.Left;
        }

        return root;
    }

    public TreeNode<T>? GetPredecessor(T element)
    {
        var node = Find(element);

        if(node == null)
        {
            return node;
        }

        if(node.Left != null)
        {
            return GetMaximumNode(node.Left);
        }

        var parent = node.Parent;

        while (parent != null && node == parent.Left)
        {
            node = parent;
            parent = parent.Parent;
        }

        return parent;
    }

    public TreeNode<T>? GetSuccessor(T element)
    {
        var node = Find(element);

        if(node == null)
        {
            return node;
        }

        if(node.Right != null)
        {
            return GetMinimumNode(node.Right);
        }

        var parent = node.Parent;

        while(parent != null && node == parent.Right)
        {
            node = parent;
            parent = parent.Parent;
        }

        return parent;
    }

    private TreeNode<T>? GetMinimumNode(TreeNode<T> node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node;
    }

    private TreeNode<T>? GetMaximumNode(TreeNode<T> node)
    {
        while(node.Right != null)
        {
            node = node.Right;
        }

        return node;
    }
}
