using System.Text;

namespace DataStructures.ElementaryDataStructures.LinkedLists;

internal class SinglyLinkedList<T> : ILinkedList<T>
{
    private Node<T>? _head { get; set; } = null;

    private int _listLength;

    public SinglyLinkedList()
    {
        _listLength = 0;
    }

    public void Insert(T element)
    {
        Node<T> node = new Node<T>(element);
        _listLength++;

        if(_head == null)
        {
            _head = node;
            return;
        }

        node.Next = _head;
        _head = node;
    }

    public void InsertAt(T element, int index)
    {
        if(index >= _listLength + 1 || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        if(index == 0)
        {
            Insert(element);
            return;
        }

        int currentIndex = 0;
        var node = _head;

        while(currentIndex < index - 1)
        {
            node = node.Next;
            currentIndex++;
        }

        var newNode = new Node<T>(element);

        newNode.Next = node.Next;
        node.Next = newNode;
    }

    public T? DeleteFirst()
    {
        if(_head == null)
        {
            return default;
        }

        T element = _head.Value;

        _head = _head.Next;
        _listLength--;

        return element;
    }

    public int Search(T element)
    {
        var node = _head;
        
        int index = 0;

        while (node != null)
        { 
            if(node.Value.Equals(element))
            {
                return index;
            }

            node = node.Next;
            index++;
        }

        return -1;
    }

    public override String ToString()
    {
        Node<T>? node = _head;

        var stringBuilder = new StringBuilder();

        while(node != null)
        {
            stringBuilder.Append(node.ToString()).Append(" ");
            node = node.Next;
        }

        return stringBuilder.ToString();
    }
}

