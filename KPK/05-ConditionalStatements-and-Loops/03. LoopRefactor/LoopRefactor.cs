
namespace LoopRefactor
{
    using System;

    class LoopRefactor
    {
        static void Main()
        {
            int expectedValue = 34;
            bool valueFound = false;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        valueFound = true;
                        break; //in the original example "i = 666" would also break the loop
                    }
                }
            }

            // More code here
            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
