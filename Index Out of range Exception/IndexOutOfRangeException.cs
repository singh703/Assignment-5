using System;

namespace Csharp
{
    class IndexOutOfRangeException
    {
        public static void Main(String[] args)
        {
            try
        {
        
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine("Attempting to access an element outside the array bounds:");
            Console.WriteLine(numbers[5]); 
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException caught: {ex.Message}");
        }

        try
        {
            Console.WriteLine("Enter a number:");
            string userInput = Console.ReadLine();
            int parsedNumber = int.Parse(userInput); 
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"FormatException caught: {ex.Message}");
        }

        try
        {
            Console.WriteLine("Attempting an invalid operation:");
            throw new InvalidOperationException("This is an example of InvalidOperationException");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"InvalidOperationException caught: {ex.Message}");
        }
        catch (Exception ex)
        {
    
            Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
        }
        }
    }
}




