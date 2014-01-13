using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MissCat
{
    static void Main()
    {
        int juryCount = int.Parse(Console.ReadLine());
        int[] cats = new int[10];
        int mostVotes = new int();
        int catWinner = new int();

        for (int i = 0; i < juryCount; i++)
        {
            cats[int.Parse(Console.ReadLine()) - 1]++;
        }

        for (int i = 0; i < cats.Length; i++)
        {
            if (cats[i] > mostVotes)
            {
                mostVotes = cats[i];
                catWinner = i + 1;
            }
        }
        Console.WriteLine(catWinner);
    }
}
