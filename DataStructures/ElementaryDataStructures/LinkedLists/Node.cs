namespace DataStructures.ElementaryDataStructures.LinkedLists;

internal class LinkedListNode<T>
{
    public LinkedListNode<T>? Previous { get; set; }

    public LinkedListNode<T>? Next { get; set; }

    public T Value { get; set; }

    public LinkedListNode(T value)
    {
        Previous = null;
        Next = null;
        this.Value = value;
    }

    public override string ToString()
    {
        if(Value == null)
        {
            return string.Empty;
        }

        return Value.ToString();
    }
}

