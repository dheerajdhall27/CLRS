using Sorting.MergeSort;
using Sorting.Utility;

var mergeSort = new MergeSort();

int[] arr = new int[] { 12, 11, 13, 5, 6, 7 };

mergeSort.Sort(arr, 0, arr.Length - 1);

Utility.Print(arr);