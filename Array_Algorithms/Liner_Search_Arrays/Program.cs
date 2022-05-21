using System;


class Program {

    static Boolean LinearSearch(int[] input, int n) {
        foreach(int current in input) {
            if (n == current) {
                return true;
            }
        }

        return false;
    }

    static void Main(string[] args) {
        int[] arr = {1, 2, 3, 4, 5, 6 };
        // Console.WriteLine(LinearSearch(arr, 4));
        // Console.WriteLine(LinearSearch(arr, 8));

        int item = Array.Find(arr, element => element == 3);
        Console.WriteLine(item);
        int[] items = Array.FindAll(arr, element => element >= 5);
        Array.ForEach(items, Console.WriteLine);
    }
}
