using static Sorting.Utils.Utils;

namespace Sorting.SortingAlgorithms;

public class HeapSort
{
    public void Sort(int[] data)
    {
        BuildMaxHeap(data);

        int heapSize = data.Length;
        for (int i = data.Length - 1; i > 0; i--)
        {
            Swap(data, i, 0);
            heapSize--;
            MaxHeapify(data, 0, heapSize);
        }
    }

    private void BuildMaxHeap(int[] data)
    {
        int heapSize = data.Length;

        int mid = data.Length / 2;
        for (int i = mid; i >= 0; i--)
        {
            MaxHeapify(data, i, heapSize);
        }
    }

    private void MaxHeapify(int[] data, int index, int heapSize)
    {
        int leftChild = 2 * index + 1;

        int rightChild = 2 * index + 2;

        var largestIndex = 0;

        if (leftChild < heapSize && data[leftChild] > data[index])
        {
            largestIndex = leftChild;
        }

        else
        {
            largestIndex = index;
        }

        if (rightChild < heapSize && data[rightChild] > data[largestIndex])
        {
            largestIndex = rightChild;
        }

        if (largestIndex != index)
        {
            Swap(data, largestIndex, index);
            MaxHeapify(data, largestIndex, heapSize);
        }
    }
}

