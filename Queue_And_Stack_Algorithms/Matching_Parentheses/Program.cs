public class Program
{
    static Boolean hasMatchingParentheses(String s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        return stack.Count == 0;
    }
    public static void Main(string[] args)
    {
       System.Console.WriteLine(hasMatchingParentheses("((hello () world))"));
    }
}