namespace Sorting.Utility;

public class Utils
{
    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    public static void Swap(int[] arr, int indexA, int indexB)
    { 
        int temp = arr[indexA];
        arr[indexA] = arr[indexB];
        arr[indexB] = temp;
    }

    public static int GetMaxFromArray(int[] arr)
    {
        int max = Int32.MinValue;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    public static int GetMinFromArray(int[] arr)
    {
        int min = Int32.MaxValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }
}

