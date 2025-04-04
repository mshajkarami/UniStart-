namespace Student_s_GPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==========================================");
            Console.WriteLine("Hi, Welcome to the GPA Calculator Program!");
            Console.WriteLine("This program was written by Mohamad Saleh Hajkarami");
            Console.WriteLine("==========================================");
            Console.ResetColor();

            while (true)
            {
                try
                {


                    Console.WriteLine("\nPlease enter the number of courses for this semester:");
                    string input = Console.ReadLine();
                    int numberOfCourses = int.Parse(input);

                    if (numberOfCourses <= 0)
                    {
                        throw new Exception("The number of courses must be a positive integer.");
                    }


                    double[] grades = new double[numberOfCourses];
                    int[] Score = new int[numberOfCourses];

                    for (int i = 0; i < numberOfCourses; i++)
                    {
                        Console.WriteLine($"Course {i + 1}:");
                        Console.Write("Enter the grade: ");
                        grades[i] = double.Parse(Console.ReadLine());

                        Console.Write("Enter the number of score: ");
                        Score[i] = int.Parse(Console.ReadLine());

                        if (grades[i] < 0 || grades[i] > 20)
                        {
                            throw new Exception("Grades must be between 0 and 20.");
                        }
                        if (Score[i] <= 0)
                        {
                            throw new Exception("Credits must be a positive integer.");
                        }
                    }

                    double totalPoints = 0;
                    int totalScore = 0;


                    for (int i = 0; i < numberOfCourses; i++)
                    {
                        totalPoints += grades[i] * Score[i];
                        totalScore += Score[i];
                    }

                    double average = totalPoints / totalScore;

                    Console.WriteLine($"\nTotal Points: {totalPoints}");
                    Console.WriteLine($"Semester GPA: {average:F2}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nTotal Points: {totalPoints}");
                    Console.WriteLine($"Semester GPA: {average:F2}");
                    Console.ResetColor();

                    Console.WriteLine("\nDo you want to calculate another GPA? (y/n):");
                    string response = Console.ReadLine().ToLower();

                    if (response != "y")
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter valid numbers.");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.ResetColor();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n==========================================");
            Console.WriteLine("Thank you for using the GPA Calculator!");
            Console.WriteLine("Goodbye! Have a great day!");
            Console.WriteLine("==========================================");
            Console.ResetColor();

        }
    }
}
