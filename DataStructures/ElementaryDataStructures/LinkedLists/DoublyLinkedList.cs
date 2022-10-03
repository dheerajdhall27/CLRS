using System.Text;

namespace DataStructures.ElementaryDataStructures.LinkedLists;

internal class DoublyLinkedList<T> : ILinkedList<T>
{
    private LinkedListNode<T> _sentinel { get; init; }

    private int _listLength;

    public DoublyLinkedList()
    {
        T? element = default(T);

        _sentinel = new LinkedListNode<T>(element);
        _sentinel.Next = null;
        _sentinel.Previous = null;

        _listLength = 0;
    }

    public T? DeleteFirst()
    {
        if(_sentinel.Next == null)
        {
            return default(T);
        }

        var firstNode = _sentinel.Next;


        _sentinel.Next = firstNode.Next;
        firstNode.Next = null;

        return firstNode.Value;
    }

    public void Insert(T element)
    {
        var newNode = new LinkedListNode<T>(element);

        _listLength++;

        if(_sentinel.Next == null)
        {
            _sentinel.Next = newNode;
            _sentinel.Previous = newNode;
            newNode.Next = _sentinel;
            newNode.Previous = _sentinel;
            return;
        }

        newNode.Next = _sentinel.Next;
        _sentinel.Next.Previous = newNode;
        _sentinel.Next = newNode;
        newNode.Previous = _sentinel;
    }

    public void InsertAt(T element, int index)
    {
        if(index >= _listLength + 1 || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        if (index == 0)
        {
            Insert(element);
            return;
        }

        _listLength++;
        var node = _sentinel.Next;

        var currentIndex = 0;

        while(currentIndex < index - 1)
        {
            node = node.Next;
            index--;
        }

        var newNode = new LinkedListNode<T>(element);

        newNode.Next = node.Next;
        node.Next = newNode;
        newNode.Previous = node;
    }

    public LinkedListNode<T>? Search(T element)
    {
        var node = _sentinel.Next;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        while (node != null)
        {
            if (comparer.Equals(node.Value, element))
            {
                return node;
            }

            node = node.Next;
        }

        return null;
    }

    public override String ToString()
    {
        LinkedListNode<T>? node = _sentinel.Next;

        var stringBuilder = new StringBuilder();

        while (node != _sentinel && node != null)
        {
            stringBuilder.Append(node.ToString()).Append(" ");
            node = node.Next;
        }

        return stringBuilder.ToString();
    }

    public void Delete(T element)
    {
        throw new NotImplementedException();
    }
}

