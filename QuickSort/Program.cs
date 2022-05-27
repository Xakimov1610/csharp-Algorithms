public class Program
{
    public static void Main(string[] args)
    {
        int[] arr =  {4,14,53,2,13,5};
        
        // for(int i = 0; i < arr.Length; i++)
        // {
        //     for(int j = i+1; j < arr.Length; j++)
        //     {
        //         if(arr[i] > arr[j])
        //         {
        //             int temp = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }
        // }

        
        // QuickSort(arr, 0, arr.Length-1);
        System.Console.WriteLine(string.Join(",", arr));

    }
    
    // static int[] QuickSort(int[] arr, int low, int high)
    // {
    //     int pivot = arr[(low + high) / 2];
    //     int i = low;
    //     int j = high;
    //     while (i <= j)
    //     {
    //         while (arr[i] < pivot)
    //         {
    //             i++;
    //         }
    //         while (arr[j] > pivot)
    //         {
    //             j--;
    //         }
    //         if (i <= j)
    //         {
    //             int temp = arr[i];
    //             arr[i] = arr[j];
    //             arr[j] = temp;
    //             i++;
    //             j--;
    //         }
    //     }
    //     if (low < j)
    //     {
    //         QuickSort(arr, low, j);
    //     }
    //     if (i < high)
    //     {
    //         QuickSort(arr, i, high);
    //     }
    //     return arr;
    // }
}