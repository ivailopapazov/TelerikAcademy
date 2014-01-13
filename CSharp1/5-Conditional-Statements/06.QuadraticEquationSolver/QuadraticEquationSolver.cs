using System;

class QuadraticEquationSolver
{
    static void Main()
    {
        // Reading coefficients from console
        double coefA = 0;
        do
        {
            Console.Write("Please eneter coefficient a != 0: ");
            coefA = double.Parse(Console.ReadLine());
        } while (coefA == 0); // Not quadratic equation if coefficient a is equal to 0
        Console.Write("Please eneter coefficient b: ");
        double coefB = double.Parse(Console.ReadLine());
        Console.Write("Please eneter coefficient c: ");
        double coefC = double.Parse(Console.ReadLine());

        // Declare root variables
        double root1;
        double root2;

        // Calculating discriminant
        double discriminant = Math.Pow(coefB, 2) - 4 * coefA * coefC;

        // Calculating roots based on three cases of discriminant
        if (discriminant > 0) // Two x axis intersections
        {
            root1 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
            root2 = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
            Console.WriteLine("Two real roots X1 = {0:F3} and X2 = {1:F3}", root1, root2);
        }
        else if (discriminant == 0) // One x axis intersection
        {
            root1 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
            Console.WriteLine("One real root X1 = {0:F3}", root1);
        }
        else // No intersections with x axis
        {
            Console.WriteLine("There are no real roots!");
        }
    }
}
