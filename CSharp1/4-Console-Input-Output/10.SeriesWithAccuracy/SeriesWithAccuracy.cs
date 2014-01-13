using System;

class SeriesWithAccuracy
{
    static void Main()
    {
        double accuracy = 1E-3;
        double sum = 1; // Sum contain the first therm of the sequence
        double nthTerm = 0;
        int i = 2; // We start with the second therm of the sequence

        // Nth Term must be evaluated first and than compared to accuracy
        do
        {
            nthTerm = 1.0 / i; // Absolute value of the Nth therm
            sum += nthTerm * Math.Pow((-1), i); // Calculating the sum while adding the sign of the Nth Therm
            i++;
        } while (nthTerm > accuracy);
        Console.WriteLine("The sum of the sequence 1, 1/2, -1/3, 1/4, -1/5, ... is {0}", sum);
    }
}
