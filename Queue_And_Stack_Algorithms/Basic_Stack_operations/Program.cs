public class Program
{
    public static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();

        System.Console.WriteLine("Start Main");
        stack.Push("Main");

        System.Console.WriteLine("Start ResponseBuilder");
        stack.Push("ResponseBuilder");

        System.Console.WriteLine("Start CallExternalService");
        stack.Push("CallExternalService");

        System.Console.WriteLine("End : " + stack.Pop());

        System.Console.WriteLine("Start ParseExternalData");
        stack.Push("ParseExternalData");

        System.Console.WriteLine("End : " + stack.Pop());
        System.Console.WriteLine("End : " + stack.Pop());
        System.Console.WriteLine("End : " + stack.Pop());

        // stack.Peek();
        // stack.TryPeek();
        string item;
        System.Console.WriteLine(stack.TryPeek(out item)); // ››› False
    }
}