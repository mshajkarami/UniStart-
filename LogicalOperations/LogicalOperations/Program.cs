using System;

namespace LogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("==========================================");
            Console.WriteLine("Hi, This program was written by Mohamad Saleh Hajkarami");
            Console.WriteLine("This program performs logical operations: AND, OR, XOR");
            Console.WriteLine("==========================================");
            Console.ResetColor();

            while (true)
            {
                try
                {

                    Console.WriteLine("Please enter the first boolean value (true/false):");
                    string input1 = Console.ReadLine();
                    bool val1 = bool.Parse(input1.ToLower());  
                    

                    Console.WriteLine("Please enter the second boolean value (true/false):");
                    string input2 = Console.ReadLine();
                    bool val2 = bool.Parse(input2.ToLower());  


                    bool andResult = val1 && val2;  
                    bool orResult = val1 || val2;   
                    bool xorResult = val1 ^ val2;  

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"AND result (val1 AND val2): {andResult}");
                    Console.WriteLine($"OR result (val1 OR val2): {orResult}");
                    Console.WriteLine($"XOR result (val1 XOR val2): {xorResult}");
                    Console.ResetColor();

                    break; 
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input! Please enter 'true' or 'false'.");
                    Console.ResetColor();
                    Console.WriteLine("Let's try again...");
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
