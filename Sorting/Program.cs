

using Sorting.QuickSort;

var quickSort = new QuickSort();

int[] arr = new int[] { 5, 4, 3, 2, 1 };
quickSort.Sort(arr, 0, arr.Length - 1);

Console.WriteLine(arr);