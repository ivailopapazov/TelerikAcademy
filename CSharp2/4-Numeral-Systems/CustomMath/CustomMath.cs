using System;

namespace CustomTools
{
    public static class CustomMath
    {
        // Fast Exponentiation Method for num > 0 and exponent >= 0
        public static int FastPow(int num, int exponent)
        {
            // Exponentiation result container
            int power = 1;

            // Exponentiation process
            for (int i = 0; i < exponent; i++)
            {
                power *= num;
            }

            // Returning result
            return power;
        }
    }
}
