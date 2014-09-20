namespace _2.GirlsGoneWild
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    class Program
    {
        static HashSet<char>[] waysToDress;
        static int girlsCount;
        static SortedSet<string> resultSet = new SortedSet<string>();
        static Dictionary<char, int> allSkirts = new Dictionary<char, int>();
        static Dictionary<char, int> usedSkirts = new Dictionary<char, int>();

        static void Main()
        {
            int shirts = int.Parse(Console.ReadLine());
            string skirts = Console.ReadLine();
            girlsCount = int.Parse(Console.ReadLine());
            waysToDress = new HashSet<char>[shirts];

            for (int i = 0; i < skirts.Length; i++)
            {
                if (!allSkirts.ContainsKey(skirts[i]))
                {
                    allSkirts[skirts[i]] = 0;
                    usedSkirts[skirts[i]] = 0;
                }

                allSkirts[skirts[i]]++;
            }

            for (int i = 0; i < shirts; i++)
            {
                waysToDress[i] = new HashSet<char>();
                for (int j = 0; j < skirts.Length; j++)
                {
                    waysToDress[i].Add(skirts[j]);
                }
            }

            KeyValuePair<int, char>[] elements = new KeyValuePair<int, char>[girlsCount];
            
            GenerateCombinations(elements, 0, 0);

            Console.WriteLine(resultSet.Count);

            foreach (var item in resultSet)
            {
                Console.WriteLine(item);
            }
        }

        static void GenerateCombinations(KeyValuePair<int, char>[] arr, int index, int start)
        {
            if (index >= girlsCount)
            {
                var result = new string[arr.Length];

                for (int i = 0; i < arr.Length; i++)
                {
                    result[i] = string.Format("{0}{1}", arr[i].Key, arr[i].Value);
                }

                resultSet.Add(string.Join("-", result));
            }
            else
            {
                for (int i = start; i < waysToDress.Length; i++)
                {
                    foreach (var skirt in waysToDress[i])
                    {
                        if (usedSkirts[skirt] < allSkirts[skirt])
                        {
                            arr[index] = new KeyValuePair<int, char>(i, skirt);
                            usedSkirts[skirt]++;
                            GenerateCombinations(arr, index + 1, i + 1);
                            usedSkirts[skirt]--;
                        }
                    }
                }
            }
        }
    }
}
