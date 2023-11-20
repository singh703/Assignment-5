using System;

namespace Csharp
{
    class validDivision
    {
        static void Main()
    {
        bool validInput = false;

        do
        {
            try
            {
                Console.Write("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                if (denominator == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero. Please enter a non-zero denominator.");
                }

                int result = numerator / denominator;
                Console.WriteLine($"Result of {numerator} / {denominator} = {result}");

                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        } while (!validInput);
    }
    }
}








