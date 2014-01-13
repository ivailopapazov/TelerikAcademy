using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindZeroSumSubset
{
    // If we consider each number of the number set to be used or not used, we have total 2 to the 5th power (5 is the numbers in the set) or 32 subsets, we substract the the empty set and we are left with 31 possible combinations. I consider bitwise logic to be the best one for this task.
    static void Main()
    {
        int numberSetSize = 5; // Number Set size by definition is 5 but it can be modificated (maybe by user :P)
        int[] numberSet = new int[numberSetSize]; // Array that will store set elements
        bool noSubSet = true;

        // Filling number set array with necessery loop iterations
        for (int i = 0; i < numberSetSize; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numberSet[i] = int.Parse(Console.ReadLine());
        }

        // Loop for each bit combination
        for (int i = 1; i < (1 << numberSetSize); i++) // i starts from 1 because 0 represents empty set
        {
            List<int> numberSubSet = new List<int>(); // the list will be used for every possible subset
            int combination = i;

            // Loop for each bit
            for (int k = 0; k < numberSetSize; k++)
            {
                if (combination % 2 == 1) // if the least significant bit is 1
                {
                    numberSubSet.Add(numberSet[k]); // creating subset based on bit number pattern
                }
                combination >>= 1; // move on to the next bit
            }

            // If subset adds to zero, print it.
            if (numberSubSet.Sum() == 0) 
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", numberSubSet)); // Appropriate number set presentation
                noSubSet = false;
            }
        }
        if (noSubSet)
        {
            Console.WriteLine("There are no subsets that adds to zero!");
        }
    }
}
