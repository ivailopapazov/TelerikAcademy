using System;

class DataManager
{
    const int MaxCount = 6;

    class OutputData
    {
        public void PrintBoolData(bool inputData)
        {
            Console.WriteLine(inputData);
        }
    }

    public static void Main()
    {
        OutputData printData = new OutputData();
        printData.PrintBoolData(true);
    }
}