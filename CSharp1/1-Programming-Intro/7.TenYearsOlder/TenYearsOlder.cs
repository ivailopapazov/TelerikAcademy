using System;

class TenYearsOlder
{
    static void Main()
    {
        byte age = 0;
        Console.Write("Please enter your age: ");
        bool isNumber = byte.TryParse(Console.ReadLine(), out age); 
        Console.WriteLine(isNumber ? "In ten years you will be {0} years old" : "Invalid age", age + 10);
    }
}
