using System;

namespace Csharp
{
    class rethrownException
    {
         public static void Main(string[] args)
        {
             try
        {
            ThrowException();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught the rethrown exception: {ex.Message}");
        }
    }

    static void ThrowException()
    {
        try
        {
            Console.WriteLine("Inside ThrowException method - attempting an operation that may cause an exception.");
           
            throw new InvalidOperationException("Original exception thrown in ThrowException method.");
        }
        catch (Exception innerEx)
        {
            Console.WriteLine($"Caught the original exception: {innerEx.Message}");
            Console.WriteLine("Rethrowing the exception...");
            throw; 
        }
    }
    }
}










