using System;
using CustomTools;
using System.Collections.Generic;

class BinaryRepresentationOfFloat
{
    static string FractionToBinay(float fraction)
    {
        // Mantissa bits container
        int[] bits = new int[23];

        // Convert fraction to bits
        for (int i = 0; i < bits.Length; i++)
        {
            // Multiply fraction by two
            fraction *= 2;

            // Check if fraction is greater or equal than 1
            if (fraction >= 1)
            {
                bits[i] = 1;
                fraction -= 1;
            }
            else
            {
                bits[i] = 0;
            }
        }

        // Return bits as string
        return string.Join("", bits);
    }
    static void Main()
    {
        // User input
        Console.Write("Please enter float number: ");
        float floatNumber = float.Parse(Console.ReadLine());

        // Get sign
        string signBit = "0";
        if (floatNumber < 0)
        {
            // Convert to positive number
            signBit = "1";
            floatNumber = -floatNumber;
        }
        
        // Calculate normal number limit
        float normalNumberLimit = (float)CustomMath.FastNegativePow(2, -126);

        // Check for denormal number
        bool isDenormal = false;
        if (floatNumber < normalNumberLimit)
        {
            isDenormal = true;
        }

        // Get fraction and exponent
        float fraction = 0.0F;
        int exponent = 0;
        if (isDenormal) // For denormal numbers
        {
            // Denormalized mantissa notation
            fraction = floatNumber;
            for (int i = 0; i < 126; i++)
            {
                fraction *= 2;
            }            
            // Exponent for denormal numbers
            exponent = -127;
        }
        else // For normal numbers
        {
            // Get normal scientific notation
            float normalizedMatissa = floatNumber;
            // Normalizing mantissa
            while (normalizedMatissa >= 2)
            {
                normalizedMatissa /= 2;
                exponent++;
            }
            while (normalizedMatissa < 1)
            {
                normalizedMatissa *= 2;
                exponent--;
            }
            // Fraction
            fraction = normalizedMatissa - 1;
        }

        // Get biased exponent
        int biasedExponent = exponent + 127;

        // Get exponent bits
        string exponentBits = Convert.ToString(biasedExponent, 2).PadLeft(8, '0');

        // Get mantissa bits
        string mantissaBits = FractionToBinay(fraction);

        // Print result
        Console.WriteLine("{0} {1} {2} ({3})", signBit, exponentBits, mantissaBits, fraction);
    }
}
