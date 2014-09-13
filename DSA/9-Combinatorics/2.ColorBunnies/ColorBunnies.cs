namespace _2.ColorBunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ColorBunnies
    {
        static void Main()
        {
            int askedBunniesCount = int.Parse(Console.ReadLine());
            Dictionary<int, int> uniqueBunniesAsked = new Dictionary<int, int>();

            for (int i = 0; i < askedBunniesCount; i++)
            {
                int bunnyAnswer = int.Parse(Console.ReadLine()) + 1;
                if (!uniqueBunniesAsked.ContainsKey(bunnyAnswer))
                {
                    uniqueBunniesAsked[bunnyAnswer] = 0;
                }

                uniqueBunniesAsked[bunnyAnswer]++;
            }

            int bunnies = 0;
            foreach (var bunny in uniqueBunniesAsked)
            {
                bunnies += (int)Math.Ceiling(bunny.Value / (double)bunny.Key) * bunny.Key;
            }

            Console.WriteLine(bunnies);
        }
    }
}
