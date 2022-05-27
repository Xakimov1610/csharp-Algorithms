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

        
        // QuickSort_1_Way(arr, 0, arr.Length-1);

        QuickSort(arr, 0, arr.Length-1);
        System.Console.WriteLine(string.Join(",", arr));

    }
    private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

        QuickSort(array, minIndex, pivotIndex - 1);

        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    public static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;

        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);

        return pivot;
    }

    public static void Swap(ref int leftItem, ref int rightItem)
    {
        int temp = leftItem;

        leftItem = rightItem;

        rightItem = temp;
    }


/////////////////////////////////////////////////////////////////////////////////


    public static int[] QuickSort_1_Way(int[] arr, int low, int high)
    {
        int pivot = arr[(low + high) / 2];
        int i = low;
        int j = high;
        while (i <= j)
        {
            while (arr[i] < pivot)
            {
                i++;
            }
            while (arr[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        if (low < j)
        {
            QuickSort_1_Way(arr, low, j);
        }
        if (i < high)
        {
            QuickSort_1_Way(arr, i, high);
        }
        return arr;
    }
}

    
