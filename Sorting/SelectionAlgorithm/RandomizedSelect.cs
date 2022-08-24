using static Sorting.Utility.Utils;

namespace Sorting.SelectionAlgorithm;

internal class RandomizedSelect
{
    public int SelectNthIndex(int[] data, int start, int end, int index)
    {
        if (start == end)
        {
            return data[start];
        }

        int partitionIndex = RandomizedPartition(data, start, end);

        if (partitionIndex == index)
        {
            return data[partitionIndex];
        }
        else if (index < partitionIndex)
        {
            return SelectNthIndex(data, start, partitionIndex - 1, index);
        }

        return SelectNthIndex(data, partitionIndex + 1, end, index);
    }

    private int RandomizedPartition(int[] data, int start, int end)
    {
        var random = new Random();

        int randomIndex = random.Next(start, end);

        Swap(data, randomIndex, end);

        return Partition(data, start, end);
    }

    private int Partition(int[] data, int start, int end)
    {
        int key = data[end];

        int index = start - 1;

        for(int i = start; i < end; i++)
        {
            if (data[i] <= key)
            {
                index++;
                Swap(data, i, index);
            }
        }

        Swap(data, index + 1, end);

        return index + 1;
    }
}
