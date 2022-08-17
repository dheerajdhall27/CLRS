namespace Sorting.Utils;

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
}

