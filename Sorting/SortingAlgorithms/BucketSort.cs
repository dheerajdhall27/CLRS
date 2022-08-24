using static Sorting.Utility.Utils;

namespace Sorting.SortingAlgorithms;

internal class BucketSort
{
    private readonly int _numberOfBuckets;

    public BucketSort(int numberOfBuckets)
    {
        _numberOfBuckets = numberOfBuckets;
    }

    public void Sort(int[] arr)
    {
        int max = GetMaxFromArray(arr);
        int min = GetMinFromArray(arr);

        int bucketCapacity = ((max - min) / _numberOfBuckets) + 1;

        List<int>[] buckets = new List<int>[_numberOfBuckets];

        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        for (int i = 0; i < arr.Length; i++)
        {
            int bucketIndex = (arr[i] - min) / bucketCapacity;

            buckets[bucketIndex].Add(arr[i]);
        }

        var insertionSort = new InsertionSort();

        for (int i = 0; i < buckets.Length; i++)
        {
            insertionSort.Sort(buckets[i]);
        }


        int index = 0;
        for(int i = 0;i < buckets.Length; i++)
        {
            for(int j = 0; j < buckets[i].Count; j++)
            {
                arr[index] = buckets[i][j];
                index++;
            }
        }
    }
}

