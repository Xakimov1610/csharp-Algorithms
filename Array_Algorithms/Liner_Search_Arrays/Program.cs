using System.Text;
// using System;


// class Program {

//     static Boolean LinearSearch(int[] input, int n) {
//         foreach(int current in input) {
//             if (n == current) {
//                 return true;
//             }
//         }

//         return false;
//     }

//     static void Main(string[] args) {
//         int[] arr = {1, 2, 3, 4, 5, 6 };
//         // Console.WriteLine(LinearSearch(arr, 4));
//         // Console.WriteLine(LinearSearch(arr, 8));

//         int item = Array.Find(arr, element => element == 3);
//         Console.WriteLine(item);
//         int[] items = Array.FindAll(arr, element => element >= 5);
//         Array.ForEach(items, Console.WriteLine);
//     }
// }


// Random rand = new Random();
  
        
// int stringlen = int.Parse(Console.ReadLine());

// bool hasUper = false;
// bool hasLower = true;
// bool hasNumber = true;
// bool hasChar = false;
// StringBuilder str = new StringBuilder();
// for(int i=0; i <= stringlen; i++)
// {
//     if (hasUper)
//     {
        
//     }
// }

// int randValue;
// // string str = "";
// char letter;

// for (int i = 0; i < stringlen; i++)
// {   
//     randValue = rand.Next(0, 26);
    
//     letter = Convert.ToChar(randValue + 65);

//     str = str + letter;
// }
// Console.Write("Random String:" + str);

public class Program
{
    int num = new Random().Next(10000); 
    private readonly Random _random = new Random();  
  
    // Generates a random number within a range.      
    public int RandomNumber(int min, int max)  
    {  
    return _random.Next(min, max);  
    }  
    public string RandomString(int size, bool lowerCase = false)  
    {  
        var builder = new StringBuilder(size);  
        
        // Unicode/ASCII Letters are divided into two blocks
        // (Letters 65–90 / 97–122):
        // The first group containing the uppercase letters and
        // the second group containing the lowercase.  

        // char is a single Unicode character  
        char offset = lowerCase ? 'a' : 'A';  
        const int lettersOffset = 26; // A...Z or a..z: length=26  
        
        for (var i = 0; i < size; i++)  
        {  
        var @char = (char)_random.Next(offset, offset + lettersOffset);  
        builder.Append(@char);  
        }  
        
        return lowerCase ? builder.ToString().ToLower() : builder.ToString();  
    }


    public static void Main(string[] args, int num)
    {
        // int num = new Random().Next(33,122);
        StringBuilder str = new StringBuilder();
        for(int i=0; i < 10; i++)
        {

            int num = new Random().Next(33,122);
            byte[] asciiBytes = Encoding.ASCII.GetDecoder(num));
            // char[] arr = Encoding.
            
            System.Console.WriteLine(num);
            
        }
        System.Console.WriteLine(str);
    }
}