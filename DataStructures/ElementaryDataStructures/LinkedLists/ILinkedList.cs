namespace DataStructures.ElementaryDataStructures.LinkedLists;

internal interface ILinkedList<T>
{
    void Insert(T element);

    void InsertAt(T element, int index);

    T? DeleteFirst();

    void Delete(T element);

    LinkedListNode<T>? Search(T element);
}

