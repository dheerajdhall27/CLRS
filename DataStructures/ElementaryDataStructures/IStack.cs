using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ElementaryDataStructures;

internal interface IStack<T>
{
    void Push(T element);

    T? Pop();

    T? Top();

    bool StackEmpty();
}

