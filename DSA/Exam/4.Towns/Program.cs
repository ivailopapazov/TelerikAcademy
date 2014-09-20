namespace _4.Towns
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static List<Town> towns = new List<Town>();

        static void Main()
        {
            int townCount = int.Parse(Console.ReadLine());
            int[] Sequence = new int[townCount];

            for (int i = 0; i < townCount; i++)
            {
                var input = Console.ReadLine().Split(' ');
                Sequence[i] = int.Parse(input[0]);
            }

            int maxLength = 1, bestEnd = 0;
            int[] L = new int[townCount];
            int[] previous = new int[townCount];
            L[0] = 1;
            previous[0] = -1;
            for (int i = 1; i < townCount; i++)
            {
                L[i] = 1;
                previous[i] = -1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (L[j] + 1 > L[i] && Sequence[j] < Sequence[i])
                    {
                        L[i] = L[j] + 1;
                        previous[i] = j;
                    }
                }
                if (L[i] > maxLength)
                {
                    bestEnd = i;
                    maxLength = L[i];
                }
            }

            Console.WriteLine();
        }
    }

    class Town
    {
        public Town(string name, int citizens)
        {
            this.Name = name;
            this.Citizens = citizens;
        }

        public string Name { get; set; }

        public int Citizens  { get; set; }
    }
}
