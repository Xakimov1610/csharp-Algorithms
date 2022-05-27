namespace Searching_Sorting_Algorithms.Sorting;

public static class SelectionSort
{
    public static void Sort(int[] arr)
    {
        int length = arr.Length;
        for(var i = 0; i < length - 1; i++)
        {
            int minIndex = i;
            for (var j = i + 1; j < length; j++)
            {
                if(arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}