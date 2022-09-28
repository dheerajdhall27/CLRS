using System.Collections;

namespace DataStructures.ElementaryDataStructures.LinkedLists.Enumerators;

internal class LinkedListEnumerator<T> : IEnumerator<T>
{
    private LinkedListNode<T> _head;

    private LinkedListNode<T> _initialHead;

    private T _current;

    public T Current => _current;    

    object IEnumerator.Current
    {
        get
        {
            return _head;
        }
    }

    public LinkedListEnumerator(LinkedListNode<T> head)
    {
        _head = head;
        _current = default;
        _initialHead = head;
    }

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        if (_head == null)
        {
            return false;
        }

        _current = _head.Value;
        _head = _head.Next;

        return true;
    }

    public void Reset()
    {
        _head = _initialHead;
    }
}

