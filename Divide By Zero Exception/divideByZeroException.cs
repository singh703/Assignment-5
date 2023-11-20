using System;
using System.Security.Cryptography;

namespace Csharp
{
    class divideByZeroException
    {
        static void Main(string[] args)
        {
            int numerator = 10;
            int denominator = 0;

            try
            {
                int result = DivideNumber(numerator,denominator);
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error:" +ex.Message);
            }
        }

        static int DivideNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator can't be zero");
            }
            return numerator / denominator;
        }
    }
}