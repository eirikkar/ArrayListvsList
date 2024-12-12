using System.Collections;
namespace ArrayListvsList;

class Program
{
    static void Main(string[] args)
    {
      ArrayList myArray = new();
      myArray.Add(1);
      myArray.Add("This is a string inside an ArrayList");
      myArray.Add('a');
      myArray.Add(true);

      foreach (var item in myArray)
      {
        Console.WriteLine(item);
      }
    }
}
