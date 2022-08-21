using static Sorting.Utils.Utils;

namespace Sorting.QuickSort;

internal class QuickSort
{
    public void Sort(int[] data, int start, int end)
    {
        if (start < end)
        {
            int partition = Partition(data, start, end);
            Sort(data, start, partition - 1);
            Sort(data, partition + 1, end);
        }
    }

    private int Partition(int[] data, int start, int end)
    {
        int key = data[end];

        int keyIndex = start - 1;

        for (int j = start; j < end; j++)
        {
            if (data[j] <= key)
            {
                keyIndex++;
                Swap(data, j, keyIndex);
            }
        }

        Swap(data, keyIndex + 1, end);

        return keyIndex + 1;
    }
}

