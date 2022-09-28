using DataStructures.ElementaryDataStructures.LinkedLists.Enumerators;
using System.Collections;
using System.Text;

namespace DataStructures.ElementaryDataStructures.LinkedLists;

internal class SinglyLinkedList<T> : ILinkedList<T>, IEnumerable<T>
{
    private LinkedListNode<T>? _head { get; set; } = null;

    private int _listLength;

    public SinglyLinkedList()
    {
        _listLength = 0;
    }

    public void Insert(T element)
    {
        LinkedListNode<T> node = new LinkedListNode<T>(element);
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

        var newNode = new LinkedListNode<T>(element);

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

    public void Delete(T element)
    {
        if(_head == null)
        {
            return;
        }

        var head = _head;

        LinkedListNode<T>? previous = default;

        EqualityComparer<T> comparer = EqualityComparer<T>.Default;

        if(comparer.Equals(head.Value, element))
        {
            DeleteFirst();
            return;
        }

        previous = head;
        head = head.Next;

        while(head != null)
        {
            if(comparer.Equals(head.Value, element))
            {
                previous.Next = head.Next;
                head.Next = null;
                break;
            }

            head = head.Next;
        }
    }

    public LinkedListNode<T>? Search(T element)
    {
        var node = _head;
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
        LinkedListNode<T>? node = _head;

        var stringBuilder = new StringBuilder();

        while(node != null)
        {
            stringBuilder.Append(node.ToString()).Append(" ");
            node = node.Next;
        }

        return stringBuilder.ToString();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(_head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

