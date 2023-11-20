using System;

namespace Csharp
{
    class CustomExceptionClass
    {
        public static void Main(String[] args)
        {
            int age = 15;

            try
            {
                if (age<18)
                {
                    throw new CustomExceptionClass("You must be at least 20 years old ");
                }
                Console.WriteLine("Access Granted");
            }
            catch (CustomExceptionClass ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
        }
    }
}