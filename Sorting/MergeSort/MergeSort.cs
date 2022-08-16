using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.MergeSort;

internal class MergeSort
{
    public void Sort(int[] data, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            Sort(data, left, mid);
            Sort(data, mid + 1, right);
            Merge(data, left, mid, right);
        }
    }

    private void Merge(int[] data, int left, int mid, int right)
    {
        int[] leftArray = new int[mid - left + 1];
        
        int[] rightArray = new int[right - mid];

        for (int i = 0; i < leftArray.Length; i++)
        {
            leftArray[i] = data[left + i];
        }

        for (int j = 0; j < rightArray.Length; j++)
        {
            rightArray[j] = data[mid + j + 1];
        }

        int arrayIndex = left;
        int leftArrayIndex = 0;
        int rightArrayIndex = 0;

        while (leftArrayIndex < leftArray.Length && rightArrayIndex < rightArray.Length)
        {
            if (leftArray[leftArrayIndex] <= rightArray[rightArrayIndex])
            { 
                data[arrayIndex] = leftArray[leftArrayIndex];
                leftArrayIndex++;
            }
            else
            {
                data[arrayIndex] = rightArray[rightArrayIndex];
                rightArrayIndex++;
            }

            arrayIndex++;
        }

        while (leftArrayIndex < leftArray.Length)
        {
            data[arrayIndex] = leftArray[leftArrayIndex];
            arrayIndex++;
            leftArrayIndex++;
        }

        while (rightArrayIndex < rightArray.Length)
        {
            data[arrayIndex] = rightArray[rightArrayIndex];
            arrayIndex++;
            rightArrayIndex++;
        }
    }
}
