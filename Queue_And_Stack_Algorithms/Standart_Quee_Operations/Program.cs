public class Program
{
    public static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>(); // FIFO

        queue.Enqueue(1);
        queue.Enqueue(8);
        queue.Enqueue(28);
        queue.Enqueue(44);
        queue.Enqueue(88);
        queue.Enqueue(55);

        int removeItem1 = queue.Dequeue();

        foreach(var item in queue)
        {
            System.Console.WriteLine($"Queue items : {item}");
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Removed item 1 : {removeItem1}");
        System.Console.WriteLine($"Removed item 2 : {queue.Dequeue()}");

        System.Console.WriteLine($"First Item queue : {queue.Peek()}");


        int current;

        while(queue.TryDequeue(out current)) // Agar Dequeue qilsa True , Agar qilmasa False qaytaradi
        {
            System.Console.WriteLine(current);
        }
    }
}