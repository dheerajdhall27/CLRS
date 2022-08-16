using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.InsertionSort;

internal class InsertionSort
{
    public void Sort(int[] data)
    {
        for (int i = 1; i < data.Length; i++)
        {
            int key = data[i];

            int currentIndex = i - 1;

            while (currentIndex >= 0 && data[currentIndex] > key)
            {
                data[currentIndex + 1] = data[currentIndex];
                currentIndex--;
            }

            data[currentIndex + 1] = key;
        }
    }
}
