namespace Searching_Sorting_Algorithms.Searching;

public class BinarySearch
{
    public static int Search(int[] arr, int number)
    {
        int left = 0, right = arr.Length - 1;
        while(left <= right)
        {
            int middle = (right + left)/2;
            if(arr[middle] == number)
            {
                return middle;
            }
            if(arr[middle] < number)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }
        return -1;
    }
    public static int RecursionSearch(int[] arr, int left, int right, int number)
    {
        if(right >= left)
        {
            int middle = (right + left)/2;
            if(arr[middle] == number)
            {
                return middle;
            }
            if(arr[middle] < number)
            {
                RecursionSearch(arr, middle + 1, right, number);
            }
            else
            {
                RecursionSearch(arr, left, middle - 1, number);
            }
        }
        return -1;
    }
}