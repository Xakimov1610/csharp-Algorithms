namespace Searching_Sorting_Algorithms.Sorting;

public static class InsertionSort
{
    public static void Sort(int[] arr)
    {
        int length = arr.Length;
        for (var i = 1; i < length; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while(key < arr[j] && j >= 0)
            {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = key; 
        }
    }
}