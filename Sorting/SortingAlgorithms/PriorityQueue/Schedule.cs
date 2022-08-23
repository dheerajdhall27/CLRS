using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.HeapSort.PriorityQueue;

internal class Schedule : IComparable<Schedule>
{
    private int _priority;

    public Schedule(int priority)
    {
        _priority = priority;
    }

    public int CompareTo(Schedule? other)
    {
        if (other == null)
        {
            return 1;
        }

        return this._priority.CompareTo(other._priority);
    }
}

