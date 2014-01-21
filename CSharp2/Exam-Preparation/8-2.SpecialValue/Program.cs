using System;
using System.Collections.Generic;

namespace _8_2.SpecialValue
{
    class Program
    {
        static int[] ReadLine()
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return Array.ConvertAll(line, int.Parse);

        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] numbers = new int[num][];

            for (int i = 0; i < num; i++)
            {
                numbers[i] = ReadLine(); 
            }

            ///

            for (int start = 0; start < numbers[0].Length; start++)
            {
                int index = numbers[0][start];
                if (index < 0)
                {
                    continue;
                }

                int row = 0;
                int path = 1;

                while (true)
                {
                    row++;
                    row = row % num;



                }

            }
        }
    }
}
