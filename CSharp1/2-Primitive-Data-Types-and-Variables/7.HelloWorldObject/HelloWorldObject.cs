using System;

class HelloWorldObject
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object concatenated = first + " " + second;
        string third = concatenated.ToString(); 
        Console.WriteLine(third);
    }
}

