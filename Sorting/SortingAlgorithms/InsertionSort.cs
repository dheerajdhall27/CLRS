namespace Sorting.SortingAlgorithms;

public class InsertionSort
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

    public void Sort(List<int> data)
    {
        for (int i = 1; i < data.Count; i++)
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
