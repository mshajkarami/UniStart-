using System;

namespace LinearEquationSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==========================================");
            Console.WriteLine("Hi, This program was written by Mohamad Saleh Hajkarami");
            Console.WriteLine("This program solves the linear equation: ax + b = 0");
            Console.WriteLine("==========================================");
            Console.ResetColor();

            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter the value of a :");
                    string inputA = Console.ReadLine();
                    double a = double.Parse(inputA); 

                    Console.WriteLine("Please enter the value of b :");
                    string inputB = Console.ReadLine();
                    double b = double.Parse(inputB); 

                    if (a == 0)
                    {
                        throw new Exception("The coefficient 'a' cannot be zero in a valid linear equation.");
                    }

                    
                    double x = -b / a;

                  
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"The solution to the equation {a}x + {b} = 0 is: x = {x}");
                    Console.ResetColor();
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
