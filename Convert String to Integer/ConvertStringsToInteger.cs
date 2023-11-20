using System;

namespace Csharp
{
    class ConvertStringsToInteger
    {
         static void Main(string[] args)
        {
            string input = "123abc";

            try
            {
                int Number = int.Parse(input);
                Console.WriteLine("Parsed Integer: " + Number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("A Format Exception Occurred" + ex.Message);
            }
        }
    }
}