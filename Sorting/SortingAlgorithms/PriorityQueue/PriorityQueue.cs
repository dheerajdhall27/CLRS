using static Sorting.Utility.Utils;

namespace Sorting.HeapSort.PriorityQueue;

internal class PriorityQueue<T> : IPriorityQueue<T>
{
    private IList<T> _priorityQueue;

    private readonly bool _isMinHeap;

    public PriorityQueue(bool isMinHeap)
    { 
        _priorityQueue = new List<T>();
        _isMinHeap = isMinHeap;
    }

    public void Clear()
    {
        _priorityQueue.Clear();
    }

    public T? Dequeue()
    {
        if (_priorityQueue.Count == 0)
        {
            return default;
        }

        T valueToReturn = _priorityQueue[0];

        Swap(0, _priorityQueue.Count - 1);

        _priorityQueue.RemoveAt(_priorityQueue.Count - 1);

        Heapify(_priorityQueue.Count - 1);

        return valueToReturn;
    }

    public void Enqueue(T data)
    {
        _priorityQueue.Add(data);

        int count = _priorityQueue.Count;

        Heapify(count - 1);
    }

    public T? Peek()
    {
        if (_priorityQueue.Count == 0)
        {
            return default;
        }

        return _priorityQueue[0];
    }

    private void Heapify(int index)
    {
        if (index == 0 || _priorityQueue.Count == 0)
        {
            return;
        }

        int parentIndex = index % 2 == 0 ? (index / 2) - 1 : index / 2;

        if (_isMinHeap)
        {
            if (Comparer<T>.Default.Compare(_priorityQueue[parentIndex], _priorityQueue[index]) > 0)
            {
                Swap(parentIndex, index);
                Heapify(parentIndex);
            }
        }
        else
        {
            if (Comparer<T>.Default.Compare(_priorityQueue[parentIndex], _priorityQueue[index]) < 0)
            {
                Swap(parentIndex, index);
                Heapify(parentIndex);
            }
        }
    }

    private void Swap(int indexA, int indexB)
    {
        T temp = _priorityQueue[indexA];
        _priorityQueue[indexA] = _priorityQueue[indexB];
        _priorityQueue[indexB] = temp;
    }
}

