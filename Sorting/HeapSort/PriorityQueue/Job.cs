using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.HeapSort.PriorityQueue;

internal class Job : IComparer<Job>
{
    private int Priority { get; set; }

    private string? JobName { get; set; }

    private DateTime JobScheduledTimeStamp { get; set; }

    public Job(int priority, string jobName, DateTime dateTime)
    {
        Priority = priority;
        
        JobName = jobName;

        JobScheduledTimeStamp = dateTime;
    }

    public int Compare(Job? x, Job? y)
    {
        if (object.ReferenceEquals(x, y))
        {
            return 0;
        }

        if (x == null || y == null)
        {
            return -1;
        }

        return x.Priority.CompareTo(y.Priority);
    }
}
