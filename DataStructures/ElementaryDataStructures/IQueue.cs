namespace DataStructures.ElementaryDataStructures;

internal interface IQueue<T>
{
    void Enqueue(T element);

    T? Dequeue();

    T? Peek();
}

