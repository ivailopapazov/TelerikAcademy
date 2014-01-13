using System;

class TenTermsOfSequence
{
    static void Main()
    {
        // Take the first 10 terms of the sequence
        for (int i = 0; i < 10; i++)
        {
            // nth term of the sequence is (n+2)*(-1)^n
            Console.WriteLine((i + 2) * Math.Pow(-1, i));
        }
    }
}
