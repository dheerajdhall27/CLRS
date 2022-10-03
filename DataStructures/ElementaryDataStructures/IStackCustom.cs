namespace DataStructures.ElementaryDataStructures;

internal interface IStackCustom<T>
{
    void Push(T element);

    T? Pop();

    T? Top();

    bool StackEmpty();

    int Size();
}

