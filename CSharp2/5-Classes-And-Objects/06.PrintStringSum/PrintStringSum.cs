using System;

class Program
{
    public class StringSum
    {
        string[] numbers;
        int sum;

        public StringSum(string inputString)
        {
            numbers = inputString.Split(' ');

            foreach (var number in numbers)
            {
                sum += int.Parse(number);
            }
        }

        public override string ToString()
        {


            return 
        }
    }
    static void Main()
    {
    }
}
