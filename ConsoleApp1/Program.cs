using ConsoleApp1.Models;

class Program
{

  static int CountOperations(int num1, int num2)
  {
    int count = 0;
    while (num1 > 0 || num2 > 0)
    {
      if (num1 > num2)
      {
        num1 -= num2;
        count++;
      }
      else if (num2 > num1)
      {
        num2 -= num1;
        count++;
      }
      else
      {
        num1 = 0;
        count++;
      }
    }
    return count;
  }
  public static void Main(string[] args)
  {
    // Student student = new Student("Giáp", 21, 6.7);

    // student.Information();

    // Console.WriteLine($"{CountOperations(2, 4)}");

    Console.WriteLine($"Text");





  }
}