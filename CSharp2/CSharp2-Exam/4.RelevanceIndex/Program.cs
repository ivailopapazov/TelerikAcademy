using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.RelevanceIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] punctuation = new char[] { ',', '.', '(', ')', ';', '-', '!', '?' };
            string needle = Console.ReadLine();
            Dictionary<string, int> lines = new Dictionary<string, int>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                // Remove punctuation
                string line = string.Join("", Console.ReadLine().Split(punctuation, StringSplitOptions.RemoveEmptyEntries));
                // match occurances count
                MatchCollection matches = Regex.Matches(line, @"\b" + needle + @"\b", RegexOptions.IgnoreCase);
                // take count
                int count = matches.Count;
                if (count > 0)
                {
                    // replace with upper case needle
                    line = Regex.Replace(line, @"\b" + needle + @"\b", needle.ToUpper(), RegexOptions.IgnoreCase);
                }
                //add to dictionary
                lines.Add(line, count);
            }

            // print
            foreach (var line in lines.OrderByDescending(key => key.Value))
            {
                Console.WriteLine(line.Key);
            }
        }
    }
}
