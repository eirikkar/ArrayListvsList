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
      
      List<Object> myList = new();
      myList.Add(1);
      myList.Add("This is a string inside a list");
      myList.Add('a');
      myList.Add(false);

      foreach (var item in myList)
      {
        Console.WriteLine(item);
      }
    
    }
}
