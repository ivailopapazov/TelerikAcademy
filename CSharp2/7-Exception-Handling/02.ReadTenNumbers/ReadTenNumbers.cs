using System;

class ReadTenNumbers
{
    static int ReadNumber(int start, int end)
    {
        // User input
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        // Throw if number is out of range
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException(string.Format("Input number is not in range ({0}, {1})", start, end)); 
        }

        // Return
        return number;
    }
    static void Main()
    {
        // Variable declaration
        int start = 1;
        int end = 100;

        try
        {
            // Ten ReadNumber calls
            for (int i = 0; i < 10; i++)
            {
                // Move start to current number
                start = ReadNumber(start, end);
            }
        }
        catch (FormatException FE)
        {
            Console.WriteLine(FE.Message);
        }
        catch (OverflowException OE)
        {
            Console.WriteLine(OE.Message);
        }
        catch (ArgumentOutOfRangeException AE)
        {
            Console.WriteLine(AE.Message);
        }
    }
}
