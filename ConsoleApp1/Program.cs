using ConsoleApp1.Models;
using System.Collections.Generic;

class Program
{
  public static void Main(string[] args)
  {
    //init a virtual databse;
    Student[] arr = [
      new Student("Nguyễn Văn A", 20, 5.5),
      new Student("Nguyễn Văn B", 24, 7.7),
      new Student("Nguyễn Văn C", 24, 8.7)
    ];
    List<Student> students = [];
    students.AddRange(arr);

    while (true)
    {
      Console.WriteLine($"Students Management Program.");
      Console.WriteLine($"1. Student List");
      Console.WriteLine($"2. Add a Student");
      Console.WriteLine($"3. Delete a Student");
      Console.WriteLine($"0. Exit");
      Console.Write($"Type 1 || 2 || 3 || 0 to continue: ");
      var option = Convert.ToInt32(Console.ReadLine());

      switch (option)
      {
        case 0:
          Console.WriteLine($"Bye.");
          Environment.Exit(0);
          break;
        case 1:
          foreach (var student in students)
          {
            student.Information();
          }
          break;
        case 2:
          int count = 1;
          Console.WriteLine($"Enter Name/Age/Score of new student, 0 to back to home");
          do
          {
            Console.WriteLine($"Student: {count}");
            Console.Write($"Name: ");
            var studentName = Convert.ToString(Console.ReadLine());
            if (studentName == "0") break;
            if (string.IsNullOrWhiteSpace(studentName))
            {
              Console.WriteLine($"Name can't be null");
              break;
            }
            Console.Write($"Age: ");
            var ageInput = Console.ReadLine();
            if (ageInput == "0") break;
            if (string.IsNullOrWhiteSpace(ageInput))
            {
              Console.WriteLine($"Age can't be null");
              break;
            }
            bool success = int.TryParse(ageInput, out int studentAge);
            if (!success)
            {
              Console.WriteLine($"Age can't be null and must be a interger > 18");
              break;
            }

            Console.Write($"Score: ");
            var studentScore = Convert.ToDouble(Console.ReadLine());
            if (studentScore == 0) break;
            try
            {
              Student newStudent = new(studentName, studentAge, studentScore);
              students.Add(newStudent);
              count++;
            }
            catch (System.Exception)
            {
              throw;
            }
          }
          while (true);

          break;
        case 3:
          break;
        default:
          break;
      }

      Console.WriteLine($"Press any key to continue...");
      Console.ReadKey();
    }
  }
}