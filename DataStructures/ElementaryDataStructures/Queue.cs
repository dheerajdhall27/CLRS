namespace DataStructures.ElementaryDataStructures;

internal class Queue<T> : IQueue<T>
{
    private IList<T> _queue;

    public Queue()
    {
        _queue = new List<T>();
    }

    public T? Dequeue()
    {
        if(_queue.Count == 0)
        {
            return default;
        }

        var element = _queue[0];

        _queue.RemoveAt(0);

        return element;
    }

    public void Enqueue(T element)
    {
        _queue.Add(element);
    }

    public T? Peek()
    {
        if(_queue.Count == 0)
        {
            return default;
        }

        return _queue[0];
    }
}

