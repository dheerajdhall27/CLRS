using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ElementaryDataStructures.LinkedLists;

internal interface ILinkedList<T>
{
    void Insert(T element);

    void InsertAt(T element, int index);

    T? DeleteFirst();

    int Search(T element);
}

