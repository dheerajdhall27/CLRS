
using Sorting.SelectionAlgorithm;

var randomizedSelect = new RandomizedSelect();

int[] arr = new int[] { 4, 2, 3, 1, 8, 9, 0 };

int value = randomizedSelect.SelectNthIndex(arr, 0, arr.Length - 1, 5);

Console.WriteLine(value);