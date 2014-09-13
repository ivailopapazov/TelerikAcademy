namespace _1.BinaryPasswords
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long combinations = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    combinations *= 2;
                }
            }

            Console.WriteLine(combinations);
        }
    }
}
