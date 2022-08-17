using Sorting.HeapSort;
using Sorting.MergeSort;
using Sorting.Utils;

var heapSort = new HeapSort();

int[] arr = new int[] { 12, 11, 13, 5, 6, 7 };

heapSort.Sort(arr);

Utils.Print(arr);

