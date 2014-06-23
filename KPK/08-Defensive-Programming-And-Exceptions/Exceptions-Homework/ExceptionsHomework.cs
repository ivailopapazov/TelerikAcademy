using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("The array is null.");
        }

        if (arr.Length == 0)
        {
            throw new InvalidOperationException("Array must have at least 1 element in it.");
        }

        if (0 > startIndex || startIndex > arr.Length - 1)
        {
            throw new ArgumentOutOfRangeException("Startindex must be between 0 and " + arr.Length);
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("Count cannot be less than 1.");
        }

        if (startIndex + count - 1 > arr.Length - 1)
        {
            throw new InvalidOperationException(string.Format("Start index({0}) + count({1}) are greater than the length of array({2})",
                startIndex, count, arr.Length));
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null)
        {
            throw new ArgumentNullException("The string is null.");
        }

        if (str == string.Empty)
        {
            throw new InvalidOperationException("Cannot extract length of empty string.");
        }

        if (count > str.Length -1)
        {
            throw new ArgumentOutOfRangeException("The count cannot be greather than the string length");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new ApplicationException(" is not prime!");
            }
        }
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        try
        {
            CheckPrime(23);
            Console.WriteLine("23 is prime.");
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine("23" + ex.Message);
        }

        try
        {
            CheckPrime(33);
            Console.WriteLine("33 is prime.");
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine("33" + ex.Message);
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
