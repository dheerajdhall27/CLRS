

using Sorting.CountingSort;
using Sorting.QuickSort;

var countingSort = new CountingSort();

int[] arr = new int[] {0, 5, 4, 3, 2, 1, 0 };
countingSort.Sort(arr);

Console.WriteLine(arr);