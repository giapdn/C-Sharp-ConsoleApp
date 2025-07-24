using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //init a virtual database;
            Student[] arr =
            [
                new Student("Nguyễn Văn A", 20, 5.5),
                new Student("Nguyễn Văn B", 24, 7.7),
                new Student("Nguyễn Văn C", 24, 8.7)
            ];
            var students = new List<Student>();
            students.AddRange(arr);

            while (true)
            {
                Console.WriteLine($"Students Management Program.");
                Console.WriteLine($"1. Student List");
                Console.WriteLine($"2. Add a Student");
                Console.WriteLine($"3. Delete a Student");
                Console.WriteLine($"0. Exit");
                Console.Write($"Type 0/1/2/3 to continue: ");
                var option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine($"Bye.");
                        Environment.Exit(0);
                        break;
                    case 1:
                        foreach (var student in students) student.Information();
                        break;
                    case 2:
                        Console.WriteLine("Quantity of students (type 0 to exit): ");
                        var quantity = Convert.ToInt32(Console.ReadLine());
                        if (quantity  == 0) break;
                        var count = 1;
                        Console.WriteLine($"Enter Name/Age/Score of new student, type 0 to exit.");
                        do
                        {
                            Console.WriteLine($"Student: {count}");
                            string studentName;
                            int studentAge;
                            double studentScore;
                            //lấy vào name
                            while (true)
                            {
                                Console.Write($"Name (not null): ");
                                var input = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(input))
                                {
                                    studentName = input;
                                    break;
                                }

                                Console.WriteLine($"Name can't be null");
                            }

                            // lấy vào age
                            while (true)
                            {
                                Console.Write($"Age (> 0): ");
                                var input = Console.ReadLine();
                                if (int.TryParse(input, out studentAge))
                                {
                                    if (studentAge is > 0) break;
                                }
                                Console.WriteLine($"Not a valid age");
                            }

                            //lấy vào score
                            while (true)
                            {
                                Console.Write($"Score ( => 0 && <= 10): ");
                                var input = Console.ReadLine();
                                if (double.TryParse(input, out studentScore))
                                {
                                    if (studentScore is >= 0 and <= 10) break;
                                }

                                Console.WriteLine("Invalid score.");
                            }

                            //try to add new student
                            try
                            {
                                Student newStudent = new(studentName, studentAge, studentScore);
                                students.Add(newStudent);
                                count++;
                                quantity--;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(
                                    $"An err occured when we try to add a new student, try again later: " + e);
                                break;
                            }
                        } while (quantity > 0);
                        break;
                    case 3:
                        break;
                }

                Console.WriteLine($"Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}