namespace Searching_Sorting_Algorithms.Sorting;

public static class BubbleSort
{
    public static void Sort(int[] arr)
    {
        int length = arr.Length;
        for (int i = 0; i < length - 1; i++)
        {
            for (int j = 0; j < length - i - 1; j++)
            {
                if(arr[j] > arr[j+1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
    }
    public static void RecursionSort(int[] arr, int n)
    {
        if(n == 1) return;
        for (var i = 0; i < n -1 ; i++)
        {
            if(arr[i] > arr[i+1])
            {
                var temp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = temp;
            }
        }
        RecursionSort(arr, n - 1);
    }
}