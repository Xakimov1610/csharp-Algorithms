using System.Text;
using System.Linq;
public class Program
{
    
    public static void Main(string[] args)
    {
       string input = "salom mani ismim palonchi";

       var spl = input.Split(' ', System.StringSplitOptions.RemoveEmptyEntries)
                      .Select(x => x.ToCharArray());

       StringBuilder result = new StringBuilder();
                      
      foreach(var item in spl)
      {
          Array.Reverse(item);
          var a = new String(item);
        
          result.Append(a);
          result.Append(" ");
      }

       
       System.Console.WriteLine(result);

       
    }
}


