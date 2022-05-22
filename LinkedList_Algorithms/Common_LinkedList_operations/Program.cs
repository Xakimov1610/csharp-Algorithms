using System;
using System.Collections.Generic;


class Program {

    static void Main(string[] args) {
        LinkedList<string> listy = new LinkedList<string>();
        // AddLast
        // AddFirst
        listy.AddLast("Sarah");
        listy.AddLast("Polly");
        listy.AddLast("Rebecca");
        listy.AddLast("Jess");
        listy.AddLast("Jackie");

        Console.WriteLine(listy.Contains("Polly"));
        Console.WriteLine(listy.Count);

        listy.RemoveFirst();
        
        foreach(string item in listy) {
            Console.Write(item + "->");
        }

        Console.WriteLine();
    }
}
