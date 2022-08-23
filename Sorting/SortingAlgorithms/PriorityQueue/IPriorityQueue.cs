using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.HeapSort.PriorityQueue;

internal interface IPriorityQueue<T>
{
    void Enqueue(T data);
    T? Dequeue();
    void Clear();
    T? Peek();
}

