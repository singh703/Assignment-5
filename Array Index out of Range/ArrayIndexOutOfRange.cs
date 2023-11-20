using System;
using System.Globalization;

namespace Csharp
{
 class ArrayIndexOutOfRange
 {
    public static void Main(String[] args)
    {
        int[] Number = {1,2,3,4,5};

        try
        {
            int index = 10;
            int value = Number[index];

            Console.WriteLine("Valie at index" + index + value);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("An Index out of Range Exception Occurred: " + ex.Message);
        } 
    }
 }   
}