using System;

class Program
{
    static void Main()
    {
        int? nullableInteger = null;
        double? nullableDouble = null;
        Console.WriteLine("Trying to print null int in quotes: \"{0}\"", nullableInteger);
        Console.WriteLine("Trying to print null double in quotes: \"{0}\"", nullableDouble);
        nullableInteger += null;
        nullableDouble += null;
        Console.WriteLine("Adding null to null integer results null: \"{0}\"", nullableInteger);
        Console.WriteLine("Adding null to null double results null: \"{0}\"", nullableDouble);
        nullableInteger += 5;
        nullableDouble += 2.718;
        Console.WriteLine("Adding integer to null integer results null: \"{0}\"", nullableInteger);
        Console.WriteLine("Adding double to null double results null: \"{0}\"", nullableDouble);

    }
}
