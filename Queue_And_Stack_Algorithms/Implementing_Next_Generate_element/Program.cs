
class Program 
{
    static void printNextGreaterElement(int[] arr) 
    {
        if (arr.Length <= 0) {
            Console.WriteLine();
            return;
        }

        Stack<int> stack = new Stack<int>();
        stack.Push(arr[0]);

        for (int i = 1; i < arr.Length; i++) {
            int next = arr[i];
            if (stack.Count > 0) {
                int popped = stack.Pop();

                while (popped < next) {
                    Console.WriteLine(popped + "-->" + next);
                    if (stack.Count == 0) {
                        break;
                    }
                    popped = stack.Pop();
                }

                if (popped > next) {
                    stack.Push(popped);
                }
            }
            stack.Push(next);
        }

        while(stack.Count > 0) {
            Console.WriteLine(stack.Pop() + " --> " + -1);
        }
    }

    static void Main(string[] args) 
    {
        int[] arr = new int[] {15, 8, 4, 10};
        int[] arr2 = new int[] {2};
        int[] arr3 = new int[] {2, 3};
        int[] arr4 = new int[] {};

        printNextGreaterElement(arr);
        printNextGreaterElement(arr2);
        printNextGreaterElement(arr3);
        printNextGreaterElement(arr4);
    }
}
