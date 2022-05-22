using System;

class Program
{

    static void ParseContents(string s) {
        Console.WriteLine("Option 1");

        foreach(char c in s) {
            Console.WriteLine(c);
        }

        Console.WriteLine("Option 2");

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            Console.WriteLine(c);
        }
    }

    static Boolean IsAtEvenIndex(String s, char item) {
        if (String.IsNullOrEmpty(s)){
            return false;
        }

        for (int i = 0; i < s.Length / 2 + 1; i=i+2) {
            if(s[i] == item) {
                return true;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World".ToLower().Contains("ll"));
        //ParseContents("Hello World");
        
        String input = "HeLLo";
        string my = "Azizza dance";
        Console.WriteLine(IsAtEvenIndex(input, 'l'));
        Console.WriteLine(IsAtEvenIndex(input, 'T'));
        Console.WriteLine(IsAtEvenIndex(input, 'H'));
        Console.WriteLine(IsAtEvenIndex("", 'H'));
        Console.WriteLine(IsAtEvenIndex(null, 'H'));
        Console.WriteLine(IsAtEvenIndex(my, 'z'));
    }
}

