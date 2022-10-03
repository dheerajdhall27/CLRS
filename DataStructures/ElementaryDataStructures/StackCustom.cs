namespace DataStructures.ElementaryDataStructures;

internal class StackCustom<T> : IStackCustom<T>
{
    private IList<T> _stack;

    public StackCustom()
    {
        _stack = new List<T>();
    }

    public T? Pop()
    {
        if (_stack.Count == 0)
        {
            return default;
        }

        var topElement = _stack[_stack.Count - 1];

        _stack.RemoveAt(_stack.Count - 1);

        return topElement;
    }

    public void Push(T element)
    {
        _stack.Add(element);
    }

    public int Size()
    {
        return _stack.Count;
    }

    public bool StackEmpty()
    {
        return _stack.Count > 0;
    }

    public T? Top()
    {
        if(StackEmpty())
        {
            return default;
        }

        return _stack[_stack.Count - 1];
    }
}

