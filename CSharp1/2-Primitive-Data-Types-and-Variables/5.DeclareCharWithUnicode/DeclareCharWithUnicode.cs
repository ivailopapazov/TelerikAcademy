using System;

class DeclareCharWithUnicode
{
    static void Main()
    {
        char character = '\u0048';
        Console.WriteLine("Symbol \"{0}\" has decimal unicode {1} and hexadecimal unicode {1:X} ", character, (int)character);
    }
}
