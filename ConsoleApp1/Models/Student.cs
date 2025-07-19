namespace ConsoleApp1.Models
{
  public class Student(string name, int age, double score)
  {
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public double Score { get; set; } = score;

    public void Information() => Console.WriteLine($"Name: {this.Name} | Age: {this.Age} | Score: {this.Score}.");

  }
}