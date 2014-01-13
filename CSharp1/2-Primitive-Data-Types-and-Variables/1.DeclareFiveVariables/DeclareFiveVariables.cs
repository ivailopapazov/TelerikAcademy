using System;

class DeclareFiveVariables
{
    static void Main()
    {
        sbyte smallNegative = -115;
        short bigNegative = -10000;
        byte smallPositive = 97;
        ushort mediumPositive = 52130;
        int bigPositive = 4825932;

        Console.WriteLine("Data type of {0} is {1}", smallNegative, smallNegative.GetTypeCode());
        Console.WriteLine("Data type of {0} is {1}", bigNegative, bigNegative.GetTypeCode());
        Console.WriteLine("Data type of {0} is {1}", smallPositive, smallPositive.GetTypeCode());
        Console.WriteLine("Data type of {0} is {1}", mediumPositive, mediumPositive.GetTypeCode());
        Console.WriteLine("Data type of {0} is {1}", bigPositive, bigPositive.GetTypeCode());
    }
}
