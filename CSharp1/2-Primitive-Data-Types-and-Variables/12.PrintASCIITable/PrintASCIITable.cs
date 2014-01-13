using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ASCII Table:");
        Console.WriteLine();

        for (int i = 0; i <= 127; i++)
        {
            Console.WriteLine("{0,-5}|{1,3}",i, (char)i );
        }
    }
}
