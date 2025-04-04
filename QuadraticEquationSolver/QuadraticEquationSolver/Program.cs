using System;

namespace QuadraticEquationSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==========================================");
            Console.WriteLine("Hi, This program was written by Mohamad Saleh Hajkarami");
            Console.WriteLine("This program solves the quadratic equation: x^2");
            Console.WriteLine("==========================================");
            Console.ResetColor();

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the value of a:");
                    string inputA = Console.ReadLine();
                    double a = double.Parse(inputA); 

                    if (a == 0)
                    {
                        throw new Exception("The coefficient 'a' cannot be zero in a valid quadratic equation.");
                    }

                    Console.WriteLine("Please enter the value of b :");
                    string inputB = Console.ReadLine();
                    double b = double.Parse(inputB); 

                    Console.WriteLine("Please enter the value of c :");
                    string inputC = Console.ReadLine();
                    double c = double.Parse(inputC);


                    double delta = (b * b) - (4 * a * c);

                    if (delta > 0)
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"The equation has two real roots: x1 = {x1} and x2 = {x2}");
                        Console.ResetColor();
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"The equation has one real root: x = {x}");
                        Console.ResetColor();
                    }
                    else
                    {
                     
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(" the delta of this Equation is <0 ");
                        Console.ResetColor();
                    }

                    break; 
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter valid numerical values.");
                    Console.ResetColor();
                    Console.WriteLine("Let's try again...");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.ResetColor();
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================");
            Console.WriteLine("Thank you for using this program!");
            Console.WriteLine("==========================================");
            Console.ResetColor();
        }
    }
}
