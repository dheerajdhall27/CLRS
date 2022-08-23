using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.SortingAlgorithms;

internal class CountingSort
{
    public void Sort(int[] data)
    {
        int max = int.MinValue;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > max)
            {
                max = data[i];
            }
        }

        int[] countArr = new int[max + 1];

        for (int i = 0; i < data.Length; i++)
        {
            countArr[data[i]] = countArr[data[i]] + 1;
        }

        for (int i = 1; i < countArr.Length; i++)
        {
            countArr[i] = countArr[i] + countArr[i - 1];
        }


        int[] resultArr = new int[data.Length];
        for (int i = data.Length - 1; i >= 0; i--)
        {
            resultArr[countArr[data[i]] - 1] = data[i];
            countArr[data[i]] = countArr[data[i]] - 1;
        }

        Array.Copy(resultArr, data, data.Length);
    }
}

