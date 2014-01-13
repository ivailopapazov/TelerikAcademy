using System;
 
class MultiTypeInput
{
    static void Main()
    {
        Console.Write("Please select data type (int, double or string): ");
        string selectedType = Console.ReadLine();
        switch (selectedType)
        {
            case "int":
                Console.Write("Please enter integer: ");
                int intInput = int.Parse(Console.ReadLine()) + 1;
                Console.WriteLine("Modificated integer is: {0}", intInput);
                break;
            case "double":
                Console.Write("Please enter double: ");
                double doubleInput = double.Parse(Console.ReadLine()) + 1;
                Console.WriteLine("Modificated double is: {0}", doubleInput);
                break;
            case "string":
                Console.Write("Please enter string: ");
                string stringInput = Console.ReadLine() + "*";
                Console.WriteLine("Modificated string is: {0}", stringInput);
                break;
            default:
                Console.WriteLine("Invalid type!");
                break;
        }
    }
}
