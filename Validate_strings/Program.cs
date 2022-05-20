using System;
using System.Linq;

class Program
{

    static Boolean IsUppercase(string s) {
        return s.All(char.IsUpper);
    }

    static Boolean IsLowercase(string s) {
        return s.All(char.IsLower);
    }

    static Boolean isPasswordComplex(string s) {
        return s.Any(char.IsUpper) && s.Any(char.IsLower) 
            && s.Any(char.IsDigit);
    }

    static void Main(string[] args)
    {
        // Console.WriteLine(IsUppercase("hello"));
        // Console.WriteLine(IsUppercase("HELLO"));

        // Console.WriteLine(IsLowercase("hello"));
        // Console.WriteLine(IsLowercase("HELLO"));

        Console.WriteLine(isPasswordComplex("Hell0"));
        Console.WriteLine(isPasswordComplex("Hello"));
        Console.WriteLine(isPasswordComplex("HellO"));
        Console.WriteLine(isPasswordComplex("HeLlo"));
        Console.WriteLine(isPasswordComplex("hello"));
        Console.WriteLine(isPasswordComplex(" "));
    }

}

