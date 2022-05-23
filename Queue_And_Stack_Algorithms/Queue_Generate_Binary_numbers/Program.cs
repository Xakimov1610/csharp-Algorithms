public class Program
{
    static void pritBinary(int n)
    {
        if(n <= 0)
            return;
        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);

        for (int i = 0; i < n; i++)
        {
            int current = queue.Dequeue();
            System.Console.WriteLine(current); 
            queue.Enqueue(current * 10);
            queue.Enqueue(current * 10 + 1);
        }
        System.Console.WriteLine();
    }
    public static void Main(string[] args)
    {
       pritBinary(5); // ››› > > ?
       pritBinary(-2); // ››› > > ?
    }
}