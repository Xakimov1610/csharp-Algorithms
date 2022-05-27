using Searching_Sorting_Algorithms.Searching;
using Searching_Sorting_Algorithms.Sorting;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int number = 10;
        SelectionSort.Sort(arr);
        Console.WriteLine(BinarySearch.Search(arr, number));
        Console.WriteLine(BinarySearch.RecursionSearch(arr, 0, arr.Length - 1, number));
    
        
    }
}
