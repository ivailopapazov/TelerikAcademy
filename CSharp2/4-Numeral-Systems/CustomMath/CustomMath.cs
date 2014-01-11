using System;

namespace CustomTools
{
    public static class CustomMath
    {
        // Fast Exponentiation Method for positive powers
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
        
        // Fast exponentiation method for negative powers

        public static double FastNegativePow(int num, int exponent)
        {
            // Exponentiation result container
            double power = 1.0;

            // Exponentiation process
            for (int i = 0; i > exponent; i--)
            {
                power /= num;
            }

            // Return result
            return power;
        }
    }
}
