using System;

namespace Csharp
{
    class nestedTryCatchBlock
    {
       public static void Main()
    {
        try
        {
            Console.WriteLine("Outer try block starts.");
            
            try
            {
                Console.WriteLine("Inner try block starts.");
                throw new InvalidOperationException("Exception in inner block");
            }
            catch (InvalidOperationException innerEx)
            {
                Console.WriteLine($"Inner catch block caught an exception: {innerEx.Message}");
                throw; 
            }
            finally
            {
                Console.WriteLine("Inner finally block executed.");
            }
            Console.WriteLine("Code after inner try-catch-finally blocks.");
        }
        catch (InvalidOperationException outerEx)
        {
            Console.WriteLine($"Outer catch block caught an exception: {outerEx.Message}");
        }
        finally
        {
            Console.WriteLine("Outer finally block executed.");
        }

        Console.WriteLine("Code after outer try-catch-finally blocks.");
    } 
    }
}






using System;

class Program
{
    
}
