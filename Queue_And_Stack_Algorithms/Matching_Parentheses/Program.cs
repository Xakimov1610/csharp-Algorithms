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

    static Boolean hasMatchingSymbolTracker(String s)
    {
        int matchingSmybolTracker = 0;
        for (int c = 0; c < s.Length; c++)
        {
            char current = s[c];
            if (current == '(')
            {
                matchingSmybolTracker++;
                continue;
            }
            if (current == ')')
            {
                matchingSmybolTracker--;
                if (matchingSmybolTracker < 0)
                {
                    return false;
                }
            }
        }
        return matchingSmybolTracker == 0;
    }
    public static void Main(string[] args)
    {
       System.Console.WriteLine(hasMatchingParentheses("((hello()))"));    // true
       System.Console.WriteLine(hasMatchingParentheses("(()(hello())"));   // false
       System.Console.WriteLine(hasMatchingParentheses("((hello))"));      // true
       System.Console.WriteLine(hasMatchingParentheses("(hello)"));        // true
       System.Console.WriteLine();
       System.Console.WriteLine(hasMatchingParentheses(")hello("));        // false
       System.Console.WriteLine(hasMatchingParentheses("())hello)"));      // false
       System.Console.WriteLine(hasMatchingParentheses("hello(("));        // false
       System.Console.WriteLine(hasMatchingParentheses("(hello"));         // false
       System.Console.WriteLine();
       System.Console.WriteLine(hasMatchingSymbolTracker("(hello()))"));   // False
       System.Console.WriteLine(hasMatchingSymbolTracker("hello()"));      // True
    }
}