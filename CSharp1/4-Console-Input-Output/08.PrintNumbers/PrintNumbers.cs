using System;

class PrintNumbers
{
    static void Main()
    {
        int number = 0;
        do
        {
            Console.Write("Please eneter positive number: ");
            number = int.Parse(Console.ReadLine());

        } while (number < 1);

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
