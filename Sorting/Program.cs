

using Sorting.SortingAlgorithms;

var bucketSort = new BucketSort(5);

int[] arr = new int[] {0, 5, 10, 4, 6, 10, 20, 40, 25, 30, 50, 60 };
bucketSort.Sort(arr);

Console.WriteLine(arr);