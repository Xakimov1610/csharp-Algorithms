public class Program
{
    static List<int> findMissingElements(int[] first, int[] second)
    {
        List<int> missingElements = new List<int>();
        HashSet<int> secondArrayItems = new HashSet<int>();

        foreach (int item in second)
        {
            secondArrayItems.Add(item);
        }

        foreach (int item in first)
        {
            if (!secondArrayItems.Contains(item))
            {
                missingElements.Add(item);
            }
        }

        return missingElements;
    }
    public static void Main(string[] args)
    {
       findMissingElements(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4 })
                        .ForEach(System.Console.WriteLine);

       System.Console.WriteLine();

       findMissingElements(new int[] { 3, 2, 8, 4, 5 }, new int[] { 5, 7, 3, 0, 2 })
                        .ForEach(System.Console.WriteLine);
    }
}