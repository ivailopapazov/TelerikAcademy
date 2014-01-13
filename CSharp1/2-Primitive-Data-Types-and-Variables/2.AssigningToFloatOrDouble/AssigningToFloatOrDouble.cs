using System;

class AssigningToFloatOrDouble
{
    static void Main()
    {
        float a = 12.345F;
        float b = 3456.091F;
        double c = 34.567839023;
        double d = 8923.1234857;

        Console.WriteLine("Data type of {0} is {1}", a, a.GetTypeCode());
        Console.WriteLine("Data type of {0} is {1}", b, b.GetTypeCode());
        Console.WriteLine("Data type of {0} is {1}", c, c.GetTypeCode());
        Console.WriteLine("Data type of {0} is {1}", d, d.GetTypeCode());
    }
}
