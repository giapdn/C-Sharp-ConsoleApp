namespace ConsoleApp1.Models
{
  public class Student(string name, int age, double score)
  {
    private string Name { get; set; } = name;
    private int Age { get; set; } = age;
    private double Score { get; set; } = score;

    public void Information() => Console.WriteLine($"Name: {Name} | Age: {Age} | Score: {Score}.");

  }
}