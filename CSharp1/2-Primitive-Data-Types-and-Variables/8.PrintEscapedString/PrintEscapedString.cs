using System;

class PrintEscapedString
{
    static void Main()
    {
        string firstString = @"The ""use"" of quotations causes difficulties.";
        string secondString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstString + " - Printed using verbatim string");
        Console.WriteLine(secondString + " - Printed using escaped characters");
    }
}
