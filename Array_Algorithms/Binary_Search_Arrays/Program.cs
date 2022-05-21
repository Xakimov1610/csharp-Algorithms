using System;


class Program {

    static Boolean BinarySearch(int[] inputArray, int item) {
        int min = 0;
        int max = inputArray.Length - 1;

        while (min <= max) {
            int mid = (min + max) / 2;
            if (item == inputArray[mid]) {
                return true;
            } else if (item < inputArray[mid]) {
                max = mid - 1;
            } else {
                min = mid + 1;
            }
        }

        return false;
    }

    static void Main(string[] args) {
        int[] arr = {1, 2, 3, 4, 5, 6 };
        Console.WriteLine(BinarySearch(arr, 5));
    }
}
